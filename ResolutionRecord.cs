using System;

namespace CET2007_Week6_Workshop
{
    /// <summary>
    /// Represents a record of a ticket resolution by an IT agent.
    /// </summary>
    public class ResolutionRecord
    {
        /// <summary>
        /// Gets or sets the ticket ID.
        /// </summary>
        public string TicketId { get; set; }

        /// <summary>
        /// Gets or sets the name of the IT agent who resolved the ticket.
        /// </summary>
        public string ITAgentName { get; set; }

        /// <summary>
        /// Gets or sets the date of the resolution.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the ResolutionRecord class.
        /// </summary>
        /// <param name="ticketId">The ticket ID.</param>
        /// <param name="itAgentName">The name of the IT agent who resolved the ticket.</param>
        /// <param name="date">The date of the resolution.</param>
        public ResolutionRecord(string ticketId, string itAgentName, DateTime date)
        {
            TicketId = ticketId;
            ITAgentName = itAgentName;
            Date = date;
        }

        /// <summary>
        /// Returns a formatted string representation of the resolution record.
        /// </summary>
        /// <returns>A string in the format "RESOLUTION RECORD - Ticket [TicketId] resolved by [ITAgentName] on [Date]".</returns>
        public override string ToString()
        {
            return $"RESOLUTION RECORD - Ticket {TicketId} resolved by {ITAgentName} on {Date:yyyy-MM-dd HH:mm:ss}";
        }
    }
}
