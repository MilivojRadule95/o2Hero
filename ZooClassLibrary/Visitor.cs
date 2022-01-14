using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalKingdom
{
    public class Visitor
    {
        private string _firstName;
        private string _lastName;
        private double _balance;
        private int _age;

        public Visitor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _balance = GenerateVisitorMoney();
            _age = GenerateVisitorAge();
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }     
        public double Balance
        {
            get { return _balance; }
        }       
        public int Age
        {
            get { return _age; }
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        private int GenerateVisitorAge() 
        {
            return new Random().Next(3, 77);
        }
        private double GenerateVisitorMoney()
        {
            return new Random().Next(700, 2500);
        }


    }
}
