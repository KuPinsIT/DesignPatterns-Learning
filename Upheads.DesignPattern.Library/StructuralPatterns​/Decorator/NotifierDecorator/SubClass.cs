namespace Upheads.DesignPattern.Library.StructuralPatterns​.Decorator
{
    class SMSDecorator : State
    {
        public SMSDecorator(BaseDecorator comp) : base(comp)
        {
        }

        public override string Send()
        {
            return $"{_base.Send()} -> SMS send!";
        }
    }

    class FacebookDecorator : State
    {
        public FacebookDecorator(BaseDecorator comp) : base(comp)
        {
        }

        public override string Send()
        {
            return $"{_base.Send()} -> Facebook send!";
        }
    }
}
