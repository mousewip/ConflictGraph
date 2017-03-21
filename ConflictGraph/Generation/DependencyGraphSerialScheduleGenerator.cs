﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConflictGraph.Analysis;

namespace ConflictGraph.Generation
{
    public class DependencyGraphSerialScheduleGenerator : ISerialScheduleGenerator
    {
        private readonly IDependencyGraphBuilder _builder;
        private readonly ISerializabilityAnalyzer _analyzer;

        public DependencyGraphSerialScheduleGenerator(
            IDependencyGraphBuilder builder,
            ISerializabilityAnalyzer analyzer)
        {
            this._builder = builder;
            this._analyzer = analyzer;
        }

        public Schedule GetSerialSchedule(Schedule originalSchedule)
        {
            if (!_analyzer.IsConflictSerializable(originalSchedule))
            {
                //throw new InvalidOperationException("Cannot generate a serial schedule for a non-conflict serializable graph.");
                MessageBox.Show("Cannot generate a serial schedule for a non-conflict serializable graph.");
            }

            var graph = _builder.GetGraph(originalSchedule);

            // walk through the graph until a node is found that has no 
            // dependencies, or all dependencies that we've already satisfied.  
            // Continue until we're done.

            var processedNodes = new List<DependencyGraphNode>();
            var steps = new List<TransactionStep>();

            foreach (var node in graph)
            {
                if (!node.Dependencies.Any())
                {
                    GenerateSchedule(node, processedNodes, steps);
                }
            }
            while (originalSchedule.Steps.Length > steps.Count)
            {
                foreach (var node in graph)
                {
                    GenerateSchedule(node, processedNodes, steps);
                }
            }
            return new Schedule()
            {
                Steps = steps.ToArray()
            };
        }

        private void GenerateSchedule(
            DependencyGraphNode node,
            List<DependencyGraphNode> processedNodes,
            List<TransactionStep> steps)
        {
            if (processedNodes.Contains(node))
            {
                return;
            }
            
            if (!node.Dependencies.Any() || !node.Dependencies.Except(processedNodes).Any())
            {
                processedNodes.Add(node);
                steps.AddRange(node.Transaction.Steps);
            }

            foreach (var dependency in node.Dependencies)
            {
                GenerateSchedule(dependency, processedNodes, steps);
            }
        }
    }
}
