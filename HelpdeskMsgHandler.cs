using System;

namespace CET2007_Week6_Workshop
{
    /// <summary>
    /// A generic message handler for the helpdesk system.
    /// </summary>
    /// <typeparam name="T">The type of message to handle.</typeparam>
    public class HelpdeskMsgHandler<T>
    {
        /// <summary>
        /// Gets or sets the name of this handler.
        /// </summary>
        public string HandlerName { get; set; }

        /// <summary>
        /// Initializes a new instance of the HelpdeskMsgHandler class.
        /// </summary>
        /// <param name="handlerName">The name of the handler.</param>
        public HelpdeskMsgHandler(string handlerName)
        {
            HandlerName = handlerName;
        }

        /// <summary>
        /// Handles a message by printing a header, the message, and a footer separator.
        /// </summary>
        /// <param name="message">The message to handle.</param>
        public void Handle(T message)
        {
            Console.WriteLine($"\n========== {HandlerName} ==========");
            Console.WriteLine(message.ToString());
            Console.WriteLine("=====================================\n");
        }
    }
}
