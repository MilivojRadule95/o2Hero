using System;
using System.Collections.Generic;

namespace ZooAnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitor visitor = new Visitor("Milivoj", "Radonic", 45000, 26);
            Console.WriteLine(visitor.Age);
            
        }
    }
}
