using System;

namespace CET2007_Week6_Workshop
{
    /// <summary>
    /// Represents a record of a ticket assignment to an IT agent.
    /// </summary>
    public class AssignmentRecord
    {
        /// <summary>
        /// Gets or sets the ticket ID.
        /// </summary>
        public string TicketId { get; set; }

        /// <summary>
        /// Gets or sets the name of the IT agent.
        /// </summary>
        public string ITAgentName { get; set; }

        /// <summary>
        /// Gets or sets the date of the assignment.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the AssignmentRecord class.
        /// </summary>
        /// <param name="ticketId">The ticket ID.</param>
        /// <param name="itAgentName">The name of the IT agent.</param>
        /// <param name="date">The date of the assignment.</param>
        public AssignmentRecord(string ticketId, string itAgentName, DateTime date)
        {
            TicketId = ticketId;
            ITAgentName = itAgentName;
            Date = date;
        }

        /// <summary>
        /// Returns a formatted string representation of the assignment record.
        /// </summary>
        /// <returns>A string in the format "ASSIGNMENT RECORD - Ticket [TicketId] assigned to [ITAgentName] on [Date]".</returns>
        public override string ToString()
        {
            return $"ASSIGNMENT RECORD - Ticket {TicketId} assigned to {ITAgentName} on {Date:yyyy-MM-dd HH:mm:ss}";
        }
    }
}
