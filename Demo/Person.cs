using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundementals.Demo
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public int Weight;
        public void Introduce()
        {
            Console.WriteLine("Hello my name is: " + FirstName + " " + LastName + "\nI am " + Age + " years old and weigh: " + Weight + " lbs.");
        }
    }
}
