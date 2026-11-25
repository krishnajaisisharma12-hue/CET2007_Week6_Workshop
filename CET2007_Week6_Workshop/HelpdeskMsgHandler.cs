using System;

namespace CET2007_Week6_Workshop
{
    /// <summary>Generic handler that prints any helpdesk message type.</summary>
    /// <typeparam name="T">Type of message to handle.</typeparam>
    public class HelpdeskMsgHandler<T>
    {
        /// <summary>Display label for the handler.</summary>
        public string HandlerName;

        /// <summary>Creates a new generic message handler.</summary>
        public HelpdeskMsgHandler(string name)
        {
            HandlerName = name;
        }

        /// <summary>Prints the message with header and footer lines.</summary>
        public void Handle(T message)
        {
            Console.WriteLine($"=== {HandlerName} ===");
            Console.WriteLine(message.ToString());
            Console.WriteLine("====================================");
            Console.WriteLine();
        }
    }
}
