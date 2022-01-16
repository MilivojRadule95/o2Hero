using ZooAnimalKingdom;
using ZooAnimalKingdom.Animals;

namespace ZooClassLibrary.TaskAndRoles
{
    public interface IAnimalFeeder
    {
        void FeedAnimalIfHungry(Animal animal);
    }
}
