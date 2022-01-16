using System;
using System.Collections.Generic;
using ZooAnimalKingdom;

namespace ZooAnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitor visitor = new Visitor("Milivoj", "Radonic");
            

            Visitor visitor1 = new Visitor("Srdjan", "Stankovic");
            Visitor visitor2 = new Visitor("Anita", "Barna");
            Visitor visitor3 = new Visitor("Svjetlana", "Saso");

            Cashier cashier = new Cashier();

            cashier.ProcessVisitor(visitor);          
        }
    }
}
