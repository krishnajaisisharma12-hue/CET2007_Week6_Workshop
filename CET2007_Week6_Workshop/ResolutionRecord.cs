using System;

namespace CET2007_Week6_Workshop
{
    /// <summary>Represents confirmation that a ticket was resolved.</summary>
    public class ResolutionRecord
    {
        /// <summary>ID of the resolved ticket.</summary>
        public string TicketId;
        /// <summary>Name of the IT agent who resolved the ticket.</summary>
        public string ITAgentName;
        /// <summary>Date and time of resolution.</summary>
        public DateTime Date;

        /// <summary>Creates a new ResolutionRecord.</summary>
        public ResolutionRecord(string ticketId, string agentName, DateTime date)
        {
            TicketId = ticketId;
            ITAgentName = agentName;
            Date = date;
        }

        /// <summary>Returns a formatted resolution record.</summary>
        public override string ToString()
        {
            return $"RESOLUTION RECORD - Ticket {TicketId} resolved by {ITAgentName} on {Date}";
        }
    }
}
