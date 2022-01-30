
using System.Collections.Generic;

namespace ZooAnimalKingdom.Buildings
{
    public static class CashierOffice
    {
        private const int FULL_TICKET_PRICE = 800;
        private const int DISCOUNT_PERCENTAGE = 50;

        private static List<Visitor> _accepted = new List<Visitor>();
        private static List<Visitor> _processed = new List<Visitor>();

        private static int zooIncome = 0;

        public static int ZooIncome { get => zooIncome; }

        public static int GetVisitorsCount() 
        {
            return _accepted.Count;
        }
        public static int GetAllPeopleCount()
        {
            return _processed.Count;
        }

        public static void AddAccepted(Visitor visitor) 
        {
            _accepted.Add(visitor);

            if (visitor.Age > 7) 
            {
                zooIncome += FULL_TICKET_PRICE;
                return;
            }

            zooIncome += TicketDiscountPrice();
        }
        public static void AddProcessed(Visitor visitor)
        {
            _processed.Add(visitor);
        }

        public static int TicketDiscountPrice() 
        {
            return FULL_TICKET_PRICE * ((100 - DISCOUNT_PERCENTAGE) / 100);
        }
        public static int TicketPrice()
        {
            return FULL_TICKET_PRICE;
        }
    }
}
