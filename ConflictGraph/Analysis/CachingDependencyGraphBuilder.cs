using System.Collections.Generic;

namespace ConflictGraph.Analysis
{
	public class CachingDependencyGraphBuilder : IDependencyGraphBuilder
	{
		private readonly IDependencyGraphBuilder _builder;
		private readonly IDictionary<Schedule, IEnumerable<DependencyGraphNode>> _dictionary; 

		public CachingDependencyGraphBuilder(IDependencyGraphBuilder builder)
		{
			this._builder = builder;
			this._dictionary = new Dictionary<Schedule, IEnumerable<DependencyGraphNode>>();
		}

		public IEnumerable<DependencyGraphNode> GetGraph(Schedule schedule)
		{
			if (_dictionary.ContainsKey(schedule))
			{
				return _dictionary[schedule];
			}

			var graph = _builder.GetGraph(schedule);

			_dictionary[schedule] = graph;

			return graph;
		}
	}
}
