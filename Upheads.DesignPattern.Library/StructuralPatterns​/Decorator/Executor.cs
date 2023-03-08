using Upheads.DesignPattern.BuildingBlocks;

namespace Upheads.DesignPattern.Library.StructuralPatterns​.Decorator
{
    public class DecoratorExecutor : PatternExecutor
    {
        public override string Name => "Decorator - Structural Pattern";

        public override void Execute()
        {
            Console.Title = "DECORATOR DESIGN PATTERN";

            EmailNotifier email = new EmailNotifier();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Original: {email.Send()}");


            SMSDecorator sms = new SMSDecorator(email);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nEmail & SMS: {sms.Send()}");


            FacebookDecorator facebook = new FacebookDecorator(email);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nEmail & Facebook: {facebook.Send()}");


            SMSDecorator email_facebook_sms = new SMSDecorator(facebook);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nAll apps: {email_facebook_sms.Send()}");

            Console.ReadKey();
        }
    }
}
