namespace CET2007_Week6_Workshop
{
    /// <summary>
    /// Represents a notification message with a title and message content.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Gets or sets the title of the notification.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the message content of the notification.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the Notification class.
        /// </summary>
        /// <param name="title">The title of the notification.</param>
        /// <param name="message">The message content.</param>
        public Notification(string title, string message)
        {
            Title = title;
            Message = message;
        }

        /// <summary>
        /// Returns a formatted string representation of the notification.
        /// </summary>
        /// <returns>A string in the format "NOTIFICATION - [Title]: [Message]".</returns>
        public override string ToString()
        {
            return $"NOTIFICATION - {Title}: {Message}";
        }
    }
}
