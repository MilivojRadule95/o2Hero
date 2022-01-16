using System;
using ZooAnimalKingdom;
using ZooAnimalKingdom.Buildings;
using ZooAnimalKingdom.Personel;

namespace ZooClassLibrary.TaskAndRoles
{
    public static class VisitorProcess
    {
        public static void DoIt(Visitor visitor, IVisitorProcess visitorProcessor) 
        {
            if (visitorProcessor is Administrator)
            {
                Console.WriteLine("Administrator is working...");
            }
            if (visitorProcessor is Cashier) 
            {
                Console.WriteLine("Cashier is working...");
            }

            CashierOffice.AddProcessed(visitor);

            Console.WriteLine($"Your balance is {visitor.Balance} RSD");

            if (visitor.Balance >= CashierOffice.TicketPrice() && visitor.Age > 7)
            {
                Console.WriteLine($"You may enter {visitor.GetFullName()}, enjoy your visit");
                CashierOffice.AddAccepted(visitor);

                return;
            }
            if (visitor.Balance >= CashierOffice.TicketDiscountPrice() && visitor.Age <= 7)
            {
                Console.WriteLine($"Be careful {visitor.GetFullName()}, and don't feed the animals");
                CashierOffice.AddAccepted(visitor);

                return;
            }

            Console.WriteLine($"Looks like you are short a few bucks");
        }
    }
}
