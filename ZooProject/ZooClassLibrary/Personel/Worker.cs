
using ZooAnimalKingdom.Animals;
using ZooClassLibrary.TaskAndRoles;

namespace ZooAnimalKingdom.Personel
{
    public class Worker : IAnimalFeeder
    {     
        public void FeedAnimalIfHungry(Animal animal)
        {
            System.Console.WriteLine();
            AnimalFeeder.DoIt(animal, this);
        }
    }
}
