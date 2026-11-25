namespace CET2007_Week6_Workshop
{
    /// <summary>
    /// Represents a support ticket in the helpdesk system.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Gets or sets the unique ticket ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the ticket title/description.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the ticket is open.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the ticket is assigned.
        /// </summary>
        public bool IsAssigned { get; set; }

        /// <summary>
        /// Gets or sets the name of the IT agent assigned to the ticket.
        /// </summary>
        public string ITAgentName { get; set; }

        /// <summary>
        /// Initializes a new instance of the Ticket class.
        /// </summary>
        /// <param name="id">The unique ticket ID.</param>
        /// <param name="title">The ticket title/description.</param>
        public Ticket(string id, string title)
        {
            Id = id;
            Title = title;
            IsOpen = true;
            IsAssigned = false;
            ITAgentName = null;
        }

        /// <summary>
        /// Returns a formatted string representation of the ticket.
        /// </summary>
        /// <returns>A string displaying ticket details including ID, title, status, and assignment.</returns>
        public override string ToString()
        {
            string status = IsOpen ? "Open" : "Closed";
            string assignedTo = IsAssigned ? ITAgentName : "Unassigned";
            return $"Ticket {Id} - {Title} | Status: {status} | Assigned To: {assignedTo}";
        }
    }
}
