namespace CET2007_Week6_Workshop
{
    /// <summary>Represents an IT helpdesk support ticket.</summary>
    public class Ticket
    {
        /// <summary>Unique ticket ID.</summary>
        public string Id;
        /// <summary>Short description of the issue.</summary>
        public string Title;
        /// <summary>True if the ticket is open; false if closed.</summary>
        public bool IsOpen;
        /// <summary>True if assigned to an IT agent.</summary>
        public bool IsAssigned;
        /// <summary>Assigned IT agent name.</summary>
        public string ITAgentName;

        /// <summary>Creates a new open, unassigned ticket.</summary>
        public Ticket(string id, string title)
        {
            Id = id;
            Title = title;
            IsOpen = true;
            IsAssigned = false;
            ITAgentName = "";
        }

        /// <summary>Returns formatted ticket details.</summary>
        public override string ToString()
        {
            string status = IsOpen ? "Open" : "Closed";
            string agent = IsAssigned ? ITAgentName : "Unassigned";
            return $"Ticket {Id} - {Title} | Status: {status} | Assigned To: {agent}";
        }
    }
}
