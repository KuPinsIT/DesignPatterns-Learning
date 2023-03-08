namespace Upheads.DesignPattern.Library.BehavioralPatterns.State
{
    // The base State class declares methods that all  State of Order should
    // implement and also provides a backreference to the Order,
    // We use it to keep the current state/status of order
    abstract class State
    {
        protected Order _order;

        public void SetContext(Order order)
        {
            this._order = order;
        }

        public abstract void Confirm();
        public abstract void Canceled();
        public abstract void Delivery();
    }
}
