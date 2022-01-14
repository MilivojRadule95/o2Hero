using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalKingdom
{
    public abstract class Animal
    {
        protected string _animalName;
        protected int _foodRequirement;
        public abstract void Eat();
    }
}
