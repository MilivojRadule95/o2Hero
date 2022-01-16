using System;
using ZooAnimalKingdom.Animals;
using ZooAnimalKingdom.Buildings;
using ZooAnimalKingdom.Personel;

namespace ZooClassLibrary.TaskAndRoles
{
    public static class AnimalFeeder
    {
        public static void DoIt(Animal animal, IAnimalFeeder animalFeeder)
        {
            if (animalFeeder is Administrator)
            {
                Console.WriteLine("Administrator is working...");
            }
            if (animalFeeder is Worker)
            {
                Console.WriteLine("Worker is working...");
            }

            if (animal.IsHungry == false)
            {
                Console.WriteLine($"{animal.AnimalName} is not hungry");
                return;
            }
            if (animal is Carnivores)
            {
                if (FoodStorage.TakeMeat(animal.FoodRequirement))
                {
                    Console.WriteLine($"{animal.AnimalName} is given {animal.FoodRequirement} kg of meat");
                    animal.Eat();
                }
                else
                {
                    Console.WriteLine("There is not enought meat in stockpile");
                }
                return;
            }
            if (animal is Herbivoers)
            {
                if (FoodStorage.TakeGrass(animal.FoodRequirement))
                {
                    Console.WriteLine($"{animal.AnimalName} is given {animal.FoodRequirement} kg of grass");
                    animal.Eat();
                }
                else
                {
                    Console.WriteLine("There is not enought grass in stockpile");
                }
                return;
            }
        }
    }
}
