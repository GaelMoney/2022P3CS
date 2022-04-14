using System;
using System.Collections.Generic;
using System.Text;

namespace getters_and_setters
{
    class Person
    {
        private int age;
        private int strength;
        
        public void SetAge(int Amount)
        {
            age = Amount;

            
        }
        public void SetStrength(int Weight)
        {
            strength = Weight;

        }
        
        public int GetAge()
        {
            return age;
        }
        public int GetStrength()
        {
            return strength;
        }
    }
}
