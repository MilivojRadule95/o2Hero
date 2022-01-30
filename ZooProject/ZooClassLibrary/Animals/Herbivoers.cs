using System;

namespace ZooAnimalKingdom.Animals
{
    public class Herbivoers : Animal
    {
        public Herbivoers(string animalName, int foodRequirement) : base(animalName, foodRequirement)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{this.AnimalName} has eaten {this._foodRequirement} kg of grass");
        }
    }
}
