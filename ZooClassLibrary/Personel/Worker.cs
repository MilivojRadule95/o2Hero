using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooClassLibrary;
using ZooClassLibrary.Personel;

namespace ZooAnimalKingdom
{
    class Worker : IAnimalFeeder
    {
        
        public void FeedAnimal(Animal animal)
        {
            FoodStorage.AddGrass(int.MaxValue);
            FoodStorage.AddMeat(int.MaxValue);

            Console.WriteLine(FoodStorage.GrassAmount);
            Console.WriteLine(FoodStorage.MeatAmount);

            Console.WriteLine("Animal have been feed");
        }
    }
}
