using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooAnimalKingdom;

namespace ZooClassLibrary.Personel
{
    interface IVisitorProcessor
    {
        public void ProcessVisitor(Visitor visitor);
    }
}
