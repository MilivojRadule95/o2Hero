using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalKingdom
{
    class Cashier
    {
        List<Visitor> visitors = new List<Visitor>();
        public void DoesVisitorGetsIn(Visitor visitor)
        {
            double personBalance = visitor.GenerateVisitorMoney();
            int personAge = visitor.GenerateVisitorAge();
            Console.WriteLine($"Your balance is {personBalance}RSD");
            if (personBalance >= 800 && personAge > 7 )
            {
                Console.WriteLine($"You may enter {visitor.GetFullName()}, enjoy your visit");
                visitors.Add(visitor);
            }
            else if (personAge <= 7 && personBalance >= 400 )
            {
                Console.WriteLine($"Be careful {visitor.GetFullName()}, and don't feed the animals");
                visitors.Add(visitor);
            }
            else
            {
                Console.WriteLine($"Back off you dumb, poor, poor bastard");
            }
        }
    }
}
