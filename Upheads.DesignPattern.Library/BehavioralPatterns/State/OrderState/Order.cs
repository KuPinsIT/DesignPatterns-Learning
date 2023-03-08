namespace Upheads.DesignPattern.Library.BehavioralPatterns.State
{
    class Order
    {
        // to reference to current state of the Order.
        private State _state = null;

        // For changing the State of Order at runtime.
        public void ChangeState(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        public Order(State state)
        {
            this.ChangeState(state);
        }

        public void ConfirmOrder()
        {
            this._state.Confirm();
        }

        public void CancelOrder()
        {
            this._state.Canceled();
        }

        public void DeliveryOrder()
        {
            this._state.Delivery();
        }

        public void GetCurrentState()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Current state: {_state.GetType().Name}.");
        }
    }





















































































    // The con cencept of State DP, that we me must have an object to store the state of Order



    enum OrderStatus
    {
        Draft = 0,
        Confirmed = 1,
        Canceled = 2,
        Delivered = 3,
    }
    class OrderSample
    {
        OrderStatus Status;

        public void ConfirmOrder()
        {
            if (Status == OrderStatus.Confirmed)
            {
                Console.WriteLine("Order already confirmed!");
            }

            if (Status == OrderStatus.Canceled)
            {
                Console.WriteLine("You can not confirm on an canceled Order!");
            }

            if (Status == OrderStatus.Delivered)
            {
                Console.WriteLine("Order already delivered!");
            }

            if (Status == OrderStatus.Draft)
            {
                Status = OrderStatus.Confirmed;
                Console.WriteLine("Success!");
            }
        }

        public void CancelOrder()
        {
            switch (Status)
            {
                case OrderStatus.Draft:
                    // Do some stuff here
                    Status = OrderStatus.Canceled;
                    Console.WriteLine("Success!");
                    break;
                case OrderStatus.Confirmed:
                    // Do some stuff here
                    Status = OrderStatus.Canceled;
                    Console.WriteLine("Success!");
                    break;
                case OrderStatus.Canceled:
                    Console.WriteLine("Order already Canceled!");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Not Allow!");
                    break;
                default:
                    break;
            }
        }
    }



}
