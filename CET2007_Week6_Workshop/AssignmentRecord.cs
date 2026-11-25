using System;

namespace CET2007_Week6_Workshop
{
    /// <summary>Represents confirmation that a ticket was assigned.</summary>
    public class AssignmentRecord
    {
        /// <summary>ID of the assigned ticket.</summary>
        public string TicketId;
        /// <summary>Name of the assigned IT agent.</summary>
        public string ITAgentName;
        /// <summary>Date and time of assignment.</summary>
        public DateTime Date;

        /// <summary>Creates a new AssignmentRecord.</summary>
        public AssignmentRecord(string ticketId, string agentName, DateTime date)
        {
            TicketId = ticketId;
            ITAgentName = agentName;
            Date = date;
        }

        /// <summary>Returns a formatted assignment record.</summary>
        public override string ToString()
        {
            return $"ASSIGNMENT RECORD - Ticket {TicketId} assigned to {ITAgentName} on {Date}";
        }
    }
}
