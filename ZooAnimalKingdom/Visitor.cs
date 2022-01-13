using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalKingdom
{
    class Visitor
    {
        private string _firstName;
        private string _lastName;
        private double _moneyBalance;
        private int _age;

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
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public double MoneyBalance
        {
            get { return _moneyBalance; }

        }
        public double GenerateVisitorMoney()
        {
            return new Random().Next(700, 2500);
        }
        public int Age
        {
            get { return _age; }
        }
        public int GenerateVisitorAge() 
        {
            return new Random().Next(3, 77);
        }

        public Visitor(string firstName, string lastName, double moneyBalace, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            _moneyBalance = moneyBalace;
            _age = age;
        }
    }
}
