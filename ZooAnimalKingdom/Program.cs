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
            Cashier cashier = new Cashier();

            cashier.ProcessVisitor(visitor);          
        }
    }
}
