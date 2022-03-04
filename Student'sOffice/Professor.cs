using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOffice
{
    class Professor
    {
        private string _professorName; //Private kojem pristupamo preko Getera.

        public Professor(string name) //Konstruktor, metod koji se poziva prilikom inicijalizacije obj. 
            //Posle public-a konstruktor nema tip promenljive koju vraća.
        {
            _professorName = name;
        }

        public string getProfessorName() //Geter
        {
            return _professorName;
        }

        
    }
}
