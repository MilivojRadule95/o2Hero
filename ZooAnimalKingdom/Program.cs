using System;
using System.Collections.Generic;
using ZooAnimalKingdom.Animals;
using ZooAnimalKingdom.Buildings;
using ZooAnimalKingdom.Personel;
using ZooClassLibrary.TaskAndRoles;

namespace ZooAnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator administrator = new Administrator();
            Worker worker = new Worker();
            Cashier cashier = new Cashier();

            List<Visitor> visitors = new List<Visitor>();
            visitors.AddRange(new Visitor[]
                             {
                                 new Visitor("Milivoj", "Radonic"),
                                 new Visitor("Srdjan", "Stankovic"),
                                 new Visitor("Anita", "Barna"),
                                 new Visitor("Svtlana", "Saso"),
                                 new Visitor("Milvoj", "Radonic"),
                                 new Visitor("Srdjan", "Stakovic"),
                                 new Visitor("Aita", "Bna"),
                                 new Visitor("Svjlana", "aso")

                             });

            List<Animal> animals = new List<Animal>();
            animals.AddRange(new Animal[]
            {
                new Carnivores("Swiss Lion", 10),
                new Carnivores("Tiger Pirot", 15),
                new Carnivores("Puma Patike", 10),
                new Carnivores("Leopard 1", 5),

                new Herbivoers("Zebra Pesacki", 10),
                new Herbivoers("Nindza Kornjaca", 30),
                new Herbivoers("Mala Zirafa", 7),
                new Herbivoers("Anoreksicni Slon", 2),
            });

            foreach (Visitor v in visitors)
            {
                Random rng = new Random();
                int num = rng.Next(100);

                if (num < 25)
                {
                    administrator.ProcessVisitor(v);
                    continue;
                }

                cashier.ProcessVisitor(v);
            }

            foreach (Animal a in animals)
            {
                Random rng = new Random();
                int num = rng.Next(100);

                if (num < 25)
                {
                    administrator.FeedAnimalIfHungry(a);
                    continue;
                }

                worker.FeedAnimalIfHungry(a);
            }

            Console.WriteLine();
            Console.WriteLine(CashierOffice.GetAllPeopleCount());
            Console.WriteLine(CashierOffice.ZooIncome);
        }
    }
}
