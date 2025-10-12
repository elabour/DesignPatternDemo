using System;

namespace DecoratorPatternExample
{
    // Step 1: Define the Component interface
    public interface INotifier
    {
        void Send(string message);
    }

    // Step 2: Create a Concrete Component
    public class BasicNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending basic notification: {message}");
        }
    }

    // Step 3: Create the Decorator base class
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _notifier;
        public NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }
        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
    // Step 4: Create Concrete Decorators
    public class EmailNotifier : NotifierDecorator
    {
        public EmailNotifier(INotifier notifier) : base(notifier) { }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending email notification: {message}");
        }
    }
    // Another Concrete Decorator for SMS notification
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(INotifier notifier) : base(notifier) { }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending SMS notification: {message}");
        }
    }
    // and another Concrete Decorator for Facebook notification
    public class FacebookNotifier : NotifierDecorator
    {
        public FacebookNotifier(INotifier notifier) : base(notifier) { }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending Facebook notification: {message}");
        }
    }

    // Step 5: Client code to demonstrate the Decorator Pattern
        internal class Program
    {
        static void Main(string[] args)
        {
            // Start with a basic notifier
            INotifier notifier = new BasicNotifier();

            // Add Email and SMS capabilities
            notifier = new EmailNotifier(notifier);
            notifier = new SMSNotifier(notifier);
            notifier = new FacebookNotifier(notifier);

            notifier.Send("Hello! You have a new message.");

        }
    }
}
