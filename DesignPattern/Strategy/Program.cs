using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket noDiscountTicket = new Ticket(new NoDiscount());
            noDiscountTicket.Price = 10;
            LogTicketDetails(noDiscountTicket);

            Ticket halfDiscountTicket = new Ticket(new HalfDiscount());
            halfDiscountTicket.Price = 10;
            LogTicketDetails(halfDiscountTicket);            

            Ticket quarterDiscountTicket = new Ticket(new QuarterDiscount());
            quarterDiscountTicket.Price = 10;
            LogTicketDetails(quarterDiscountTicket);

            Console.ReadLine();
        }

        private static void LogTicketDetails(Ticket ticket)
        {
            Console.WriteLine($"{ticket.DiscountStrategy.GetType()}: {ticket.Price} => {ticket.DoDiscount()}");
        }
    }
}
