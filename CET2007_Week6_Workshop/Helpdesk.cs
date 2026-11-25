using System;
using System.Collections.Generic;

namespace CET2007_Week6_Workshop
{
    /// <summary>Manages tickets using List, Dictionary, Queue, and Stack.</summary>
    public class Helpdesk
    {
        private List<Ticket> tickets = new List<Ticket>();
        private Dictionary<string, Ticket> byId = new Dictionary<string, Ticket>();
        private Queue<string> waitingQueue = new Queue<string>();
        private Stack<Ticket> assignmentStack = new Stack<Ticket>();

        private HelpdeskMsgHandler<Notification> notify =
            new HelpdeskMsgHandler<Notification>("Notification Message Handler");
        private HelpdeskMsgHandler<AssignmentRecord> assignMsg =
            new HelpdeskMsgHandler<AssignmentRecord>("Assignment Message Handler");
        private HelpdeskMsgHandler<ResolutionRecord> resolveMsg =
            new HelpdeskMsgHandler<ResolutionRecord>("Resolution Message Handler");

        /// <summary>Adds a new ticket if its ID does not already exist.</summary>
        public void AddTicket(Ticket ticket)
        {
            if (byId.ContainsKey(ticket.Id))
            {
                notify.Handle(new Notification("Duplicate Ticket ID",
                    $"Ticket {ticket.Id} already exists. Duplicate ID not allowed."));
                return;
            }

            tickets.Add(ticket);
            byId.Add(ticket.Id, ticket);
            notify.Handle(new Notification("Ticket Added",
                $"Ticket {ticket.Id} - Added successfully."));
        }

        /// <summary>Displays all tickets in the helpdesk.</summary>
        public void ShowAllTickets()
        {
            Console.WriteLine("=== ALL CURRENT TICKETS ===");
            foreach (Ticket t in tickets)
            {
                Console.WriteLine("- " + t.ToString());
            }
            Console.WriteLine("===========================");
        }

        /// <summary>Assigns a ticket to an agent or adds it to the waiting queue.</summary>
        public void AssignTicket(string id, string agentName)
        {
            if (!byId.ContainsKey(id))
            {
                notify.Handle(new Notification("Assignment Failed", $"Ticket {id} not found."));
                return;
            }

            Ticket t = byId[id];

            if (!t.IsOpen)
            {
                notify.Handle(new Notification("Assignment Failed", $"Ticket {id} is already closed."));
                return;
            }

            if (t.IsAssigned)
            {
                waitingQueue.Enqueue(id);
                notify.Handle(new Notification("Waitlist",
                    $"Ticket {id} is currently assigned. Your request has been added to the waiting list."));
                return;
            }

            t.IsAssigned = true;
            t.ITAgentName = agentName;
            assignmentStack.Push(t);
            assignMsg.Handle(new AssignmentRecord(id, agentName, DateTime.Now));
        }

        /// <summary>Displays all ticket IDs in the waiting queue.</summary>
        public void ShowWaitingQueue()
        {
            Console.WriteLine("=== WAITING QUEUE ===");
            if (waitingQueue.Count == 0)
            {
                Console.WriteLine("No pending Ticket assignment requests.");
            }
            else
            {
                foreach (string id in waitingQueue)
                {
                    Console.WriteLine("- " + id);
                }
            }
            Console.WriteLine("=====================");
        }

        /// <summary>Undoes the most recent ticket assignment.</summary>
        public void UndoLastAssignment()
        {
            if (assignmentStack.Count == 0)
            {
                notify.Handle(new Notification("Undo", "Nothing to undo."));
                return;
            }

            Ticket last = assignmentStack.Pop();
            last.IsAssigned = false;
            last.ITAgentName = "";
            notify.Handle(new Notification("Undo Assignment",
                $"Assignment of \"{last.Title}\" has been undone. Ticket is now unassigned again."));
        }

        /// <summary>Closes a ticket and notifies the next item in the waiting queue.</summary>
        public void ResolveTicket(string id, string agentName)
        {
            if (!byId.ContainsKey(id))
            {
                notify.Handle(new Notification("Resolution Failed", $"Ticket {id} not found."));
                return;
            }

            Ticket t = byId[id];

            if (!t.IsOpen)
            {
                notify.Handle(new Notification("Resolution Skipped", $"Ticket {id} is already closed."));
                return;
            }

            t.IsOpen = false;
            t.IsAssigned = false;
            t.ITAgentName = "";
            resolveMsg.Handle(new ResolutionRecord(id, agentName, DateTime.Now));

            if (waitingQueue.Count > 0)
            {
                string nextId = waitingQueue.Dequeue();
                notify.Handle(new Notification("Agent Available",
                    $"Ticket {nextId} can now be assigned to the next available IT agent."));
            }
        }
    }
}
