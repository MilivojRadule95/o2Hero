using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooClassLibrary;

namespace ZooAnimalKingdom
{
    class Carnivores : Animal
    {
        public override void Eat()
        {
            if (FoodStorage.TakeMeat(10))
            {
                Console.WriteLine("Animal got food");
            }
            else
            {
                Console.WriteLine("There is not enough food");
            }
        }
    }
}
