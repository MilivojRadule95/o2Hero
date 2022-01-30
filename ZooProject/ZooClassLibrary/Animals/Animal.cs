using System;


namespace ZooAnimalKingdom.Animals
{
    public abstract class Animal
    {
        private string _animalName;
        protected int _foodRequirement;

        public Animal(string animalName, int foodRequirement)
        {
            _animalName = animalName;
            _foodRequirement = foodRequirement;
        }
        public bool IsHungry 
        { 
            get 
            {
                int num = new Random().Next(100);
                if (num < 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }

        public string AnimalName 
        {
            get 
            {
                return _animalName;
            }
        }

        public int FoodRequirement
        {
            get
            {
                return _foodRequirement;
            }
        }

        public abstract void Eat();
    }
}
