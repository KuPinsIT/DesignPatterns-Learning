using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder;

namespace Upheads.DesignPattern.Consoles
{

    public class PatternExecutorsRegistry
    {
        private static PatternExecutorsRegistry? _instance;
        private readonly SortedDictionary<int, PatternExecutor> _executors;

        private PatternExecutorsRegistry()
        {
            var patternExecutors = new List<PatternExecutor>
        {
            new BuilderExecutor(),
            //new RestaurantManagement.Executor()
        };

            var serialNumber = 1;
            _executors = new SortedDictionary<int, PatternExecutor>();

            foreach (var executor in patternExecutors.OrderBy(pattern => pattern.Name))
            {
                _executors.Add(serialNumber++, executor);
            }
        }

        public static PatternExecutorsRegistry Instance => _instance ??= new PatternExecutorsRegistry();

        public SortedDictionary<int, PatternExecutor> GetAll() => _executors;
    }
}
