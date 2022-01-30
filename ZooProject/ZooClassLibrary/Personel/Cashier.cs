
using ZooClassLibrary.TaskAndRoles;

namespace ZooAnimalKingdom.Personel
{
    public class Cashier : IVisitorProcess
    {            
        public void ProcessVisitor(Visitor visitor)
        {
            System.Console.WriteLine();
            VisitorProcess.DoIt(visitor, this);
        }
    }
}
