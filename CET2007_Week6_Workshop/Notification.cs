namespace CET2007_Week6_Workshop
{
    /// <summary>Represents a general helpdesk notification.</summary>
    public class Notification
    {
        /// <summary>Title of the notification.</summary>
        public string Title;
        /// <summary>Body text of the notification.</summary>
        public string Message;

        /// <summary>Creates a new Notification.</summary>
        public Notification(string title, string message)
        {
            Title = title;
            Message = message;
        }

        /// <summary>Returns a formatted notification message.</summary>
        public override string ToString()
        {
            return $"NOTIFICATION - {Title}: {Message}";
        }
    }
}
