using System;
using System.Collections.Generic;
using System.Linq;
using ConflictGraph.Analysis;
using ConflictGraph.Generation;
using ConflictGraph.Models;
using ConflictGraph.Parsing;

namespace ConflictGraph
{
    public class Process
    {
        public static Dictionary<int, List<int>> DSK;
        public static bool result = false;
        public static string a = " ";
        public static string serialSchedule;
        public static void Caculate(string input)
        {
            var dependencyGraphBuilder = new CachingDependencyGraphBuilder(new DependencyGraphBuilder(new AllStepPairInspector()));

            ISerializabilityAnalyzer analyzer = new DependencyGraphSerializabilityAnalyzer(dependencyGraphBuilder, new DepthFirstCycleChecker());

            ISerialScheduleGenerator generator = new DependencyGraphSerialScheduleGenerator(dependencyGraphBuilder, analyzer);
            
            // we want three outputs:

            // is the given schedule conflict serializable?
            // what are the dependencies for each transaction?
            // what is the serial schedule, if it is conflict serializable?

            var scheduleInput = new StringScheduleInput(new ScheduleParser(), input);

            var dependencyGraph = dependencyGraphBuilder.GetGraph(scheduleInput.Schedule);

            var isConflictSerializable = analyzer.IsConflictSerializable(scheduleInput.Schedule);

            result = isConflictSerializable;

            DSK = new Dictionary<int, List<int>>();

            foreach (var node in dependencyGraph)
            {
                // Console.WriteLine("Transaction {0} depends upon: {1}", node.Transaction, string.Join(", ", node.Dependencies.Select(n => n.Transaction)));
                List<int> ds = new List<int>();
                ds.Add(int.Parse(node.Transaction.ToString()));
                foreach (var p in node.Dependencies)
                {
                    ds.Add(int.Parse(p.ToString()));
                }
                DSK.Add(int.Parse(node.Transaction.ToString()), ds);
            }

            if (isConflictSerializable)
            {
                serialSchedule = generator.GetSerialSchedule(scheduleInput.Schedule).ToString();
            }
        }



        public static StringScheduleInput StringSchedule(string input)
        {
            return new StringScheduleInput(new ScheduleParser(), input);
        }



        public static GraphExample GenerateGraph()
        {
            //FOR DETAILED EXPLANATION please see SimpleGraph example project
            var dataGraph = new GraphExample();
            if (DSK != null)
                foreach (var key in DSK.Keys)
                {
                    var dataVertex = new DataVertex(key.ToString());
                    dataGraph.AddVertex(dataVertex);
                }

            var vlist = dataGraph.Vertices.ToList();

            //Then create two edges optionaly defining Text property to show who are connected

            DataEdge dataEdge;
            foreach (var p in vlist)
            {
                foreach (var k in DSK)
                {
                    if (k.Key.ToString() == p.ToString())
                    {
                        foreach (var val in k.Value)
                        {
                            foreach (var v in vlist)
                            {
                                if (v.ToString() == val.ToString())
                                {
                                    dataEdge = new DataEdge(v, p);
                                    dataGraph.AddEdge(dataEdge);
                                }
                            }
                        }
                    }
                }
            }
            return dataGraph;
        }
    }
}
