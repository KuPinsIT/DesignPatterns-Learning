namespace Upheads.DesignPattern.Library.StructuralPatterns​.Decorator
{
    class EmailNotifier : BaseDecorator
    {
        public override string Send()
        {
            return "Email send!";
        }
    }
}


