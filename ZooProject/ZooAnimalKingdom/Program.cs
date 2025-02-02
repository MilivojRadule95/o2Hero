﻿using System;
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
                                 new Visitor("Milan", "Todorovic"),
                                 new Visitor("Vesna", "Mrgud"),
                                 new Visitor("Teofilija", "Opancic"),
                                 new Visitor("Levi", "Civitas"),
                                 new Visitor("Mirza", "Kaludjerski"),
                                 new Visitor("Lepi", "Brka"),
                                 new Visitor("Vojin", "Preljub"),
                                 new Visitor("Stevan", "Andjelovic")

                             });

            List<Animal> animals = new List<Animal>();
            animals.AddRange(new Animal[]
            {
                new Carnivores("Swiss Lion", 10),
                new Carnivores("Tiger Pirot", 15),
                new Carnivores("Puma Patike", 10),
                new Carnivores("Leopard 1", 5),

                new Herbivoers("Pesacki Zebra", 10),
                new Herbivoers("Ninja Turtle", 30),
                new Herbivoers("Short Giraphe", 7),
                new Herbivoers("Anorexic Elephant", 2),
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
            Console.WriteLine($"The ZOO had {CashierOffice.GetAllPeopleCount()} visitors.");
            Console.WriteLine();
            Console.WriteLine($"{CashierOffice.GetVisitorsCount()} have managed to enter.");
            Console.WriteLine();
            Console.WriteLine($"{CashierOffice.ZooIncome}RSD ZOO has earned.");
        }
    }
}
