using Upheads.DesignPattern.BuildingBlocks;
using Upheads.DesignPattern.Library.BehavioralPatterns.State;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder;
using Upheads.DesignPattern.Library.StructuralPatterns.Decorator;

namespace Upheads.DesignPattern.Consoles
{
    public class ClearConsoleExecutor : PatternExecutor
    {
        public override string Name => "Clear";
        public override void Execute()
        {
            Console.Clear();
        }
    }

    public class PatternExecutorsRegistry
    {
        private static PatternExecutorsRegistry? _instance;
        private readonly SortedDictionary<int, PatternExecutor> _executors;

        private PatternExecutorsRegistry()
        {
            var patternExecutors = new List<PatternExecutor>
        {
            new FactoryMethodExecutor(),
            new BuilderExecutor(),
            new DecoratorExecutor(),
            new StateExecutor(),
            new ClearConsoleExecutor()
        };

            var serialNumber = 1;
            _executors = new SortedDictionary<int, PatternExecutor>();

            foreach (var executor in patternExecutors)
            {
                _executors.Add(serialNumber++, executor);
            }
        }

        public static PatternExecutorsRegistry Instance => _instance ??= new PatternExecutorsRegistry();

        public SortedDictionary<int, PatternExecutor> GetAll() => _executors;
    }
}
