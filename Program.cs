using System;
using CSharpFundementals.Demo;

namespace CSharpFundementals {
    class Program
    {
        static void Main(string[] args)
        {
            string boilerplate = "\n-------------------------------------\n";
            Output("Welcome to the code file for all of my C# Knowledge.... Oh lord...");
            Output(boilerplate);
            Alex(); //Runs the object code from the Alex Method
            Output(boilerplate);
            Addition(); //Runs the addition code from the Addition Method.
            Output(boilerplate);
            Array(); // Runs the below Array Method
        }

        //Misc Shit
        public static void Output(string txt)
        {
            Console.WriteLine(txt);
        }

        //Actual demos in action
        public static void Alex() //A basic example of use of code from the /Demo/Person.cs file
        {
            Output("Demo profile: ");
            var alex = new Person();
            alex.FirstName = "Alex";
            alex.LastName = "Kollar";
            alex.Age = 28;
            alex.Weight = 270; 
            alex.Introduce();
        }

        public static void Addition() //A Basic example of the calculator addition code found in /Demo/Calculator.cs
        {
            Output("Demo Calculation: ");
            Calculator calc = new Calculator();
            var result = calc.Add(1, 2);
            Output("The answer to 1 + 2 = " + result);
        }

        public static void Array()//Container for running the array code in main();
        {
            Output("Demo Array: ");
            //a basic array setup - This same idea can be applied to Boolean arrays as well.
            var numbers = new int[3];
            numbers[0] = 1;

            Output("The first number in the arry is: " + numbers[0] + "\n");

            //What about strings? Lets use Object initialization this time...
            var names = new string[3] { "Alex", "Sam", "Brad" };
            //I did not feel I needed an extra three lines to print out three names... Because code logic!
            Output("The names in the list are:" + $"\n1.) {names[0]} \n2.) {names[1]} \n3.) {names[2]}");
        }
    }
}
