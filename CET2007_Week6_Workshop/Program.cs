using System;

namespace CET2007_Week6_Workshop
{
    /// <summary>Main entry point with interactive console menu.</summary>
    public class Program
    {
        /// <summary>Starts the IT Helpdesk application.</summary>
        public static void Main(string[] args)
        {
            Helpdesk desk = new Helpdesk();

            desk.AddTicket(new Ticket("IT-1001", "Wi-Fi not connecting in Lab A"));
            desk.AddTicket(new Ticket("IT-1002", "Password reset required"));
            desk.AddTicket(new Ticket("IT-1003", "Printer jam in Room 204"));

            bool running = true;
            while (running)
            {
                Console.WriteLine("=== IT HELP DESK MENU ===");
                Console.WriteLine("1) Add ticket");
                Console.WriteLine("2) Assign ticket");
                Console.WriteLine("3) Resolve ticket");
                Console.WriteLine("4) Undo last assignment");
                Console.WriteLine("5) Show all tickets");
                Console.WriteLine("6) Show waiting queue");
                Console.WriteLine("0) Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Ticket ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        desk.AddTicket(new Ticket(id, title));
                        break;

                    case "2":
                        Console.Write("Enter Ticket ID: ");
                        string aId = Console.ReadLine();
                        Console.Write("Enter IT Agent Name: ");
                        string agent = Console.ReadLine();
                        desk.AssignTicket(aId, agent);
                        break;

                    case "3":
                        Console.Write("Enter Ticket ID: ");
                        string rId = Console.ReadLine();
                        Console.Write("Enter Resolver Name: ");
                        string resolver = Console.ReadLine();
                        desk.ResolveTicket(rId, resolver);
                        break;

                    case "4":
                        desk.UndoLastAssignment();
                        break;

                    case "5":
                        desk.ShowAllTickets();
                        break;

                    case "6":
                        desk.ShowWaitingQueue();
                        break;

                    case "0":
                        running = false;
                        Console.WriteLine("Program ended.");
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
