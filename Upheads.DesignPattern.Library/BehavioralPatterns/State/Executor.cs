using Upheads.DesignPattern.BuildingBlocks;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.State
{
    public class StateExecutor : PatternExecutor
    {
        public override string Name => "State - Behavioral Pattern";

        public override void Execute()
        {
            var order = new Order(new DraftState());
            order.GetCurrentState();
            Console.WriteLine("");

            order.ConfirmOrder();
            order.GetCurrentState();
            Console.WriteLine("");

            order.DeliveryOrder();
            order.GetCurrentState();
            Console.WriteLine("");

            order.CancelOrder();
            order.GetCurrentState();
        }
    }
}
