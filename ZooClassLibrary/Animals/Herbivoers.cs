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
            Console.WriteLine($"{this.AnimalName} got {this._foodRequirement} of grass");
        }
    }
}
