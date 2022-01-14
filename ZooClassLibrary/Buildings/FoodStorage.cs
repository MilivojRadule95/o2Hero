using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooClassLibrary
{
    public static class FoodStorage
    {
        private static int _meatAmount;
        private static int _grassAmount;

        private const int MAX_MEAT = 500;
        private const int MAX_GRASS = 500;

        public static int MeatAmount { get => _meatAmount;}
        public static int GrassAmount { get => _grassAmount;}

        public static void AddMeat(int amount) 
        {
            if (amount < 0) 
            {
                return;
            }
            
            _meatAmount += amount;

            if (_meatAmount > MAX_MEAT) 
            {
                _meatAmount = MAX_MEAT;
            }
        }
        public static void AddGrass(int amount)
        {
            if (amount < 0)
            {
                return;
            }

            _grassAmount += amount;

            if (_grassAmount > MAX_GRASS) 
            {
                _grassAmount = MAX_GRASS;
            }
        }
        public static bool TakeMeat(int amount)
        {
            if (amount < 0)
            {
                return false;
            }
            if (amount > _meatAmount) 
            {
                return false;
            }

            _meatAmount -= amount;
            return true;
        }
        public static bool TakeGrass(int amount)
        {
            if (amount < 0)
            {
                return false;
            }
            if (amount > _grassAmount)
            {
                return false;
            }

            _grassAmount -= amount;
            return true;
        }
    }
}
