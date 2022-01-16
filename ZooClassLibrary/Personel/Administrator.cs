using ZooAnimalKingdom.Animals;
using ZooClassLibrary.TaskAndRoles;

namespace ZooAnimalKingdom.Personel
{
    public class Administrator : IVisitorProcess, IAnimalFeeder
    {
        public void FeedAnimalIfHungry(Animal animal)
        {
            System.Console.WriteLine();
            AnimalFeeder.DoIt(animal, this);
        }

        public void ProcessVisitor(Visitor visitor)
        {
            System.Console.WriteLine();
            VisitorProcess.DoIt(visitor, this);
        }
    }
}