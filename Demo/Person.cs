using System;
using System.Collections.Generic;
using System.Text;
using CSharpFundementals.Demo;

namespace CSharpFundementals.Demo
{
    public class Person
    {
        public string FirstName, LastName;
        public int Age, Weight;

        public static void Output(string txt)
        {
            Console.WriteLine(txt);
        }
        public static void Email()
        {
            //Using verbatum strings to emulate an email message. Interesting.
            var message = 
            
@"Hello Sam,
I hope this message finds you well.
As it sits I need you to find a code file for me...

Take look in the following directories:
    c:\users\zilva\documents\github
    c:\users\zilva\code\4@X

Thank you kindly,
- Alex";
            Output(message);
        }
        static void Description()
        {
            var Hobby = "gaming";
            var Passion = "Coding";
            var DreamJob = "Game Development";
            //Just a little bit of interpolation here. :P
            var ProfileDesc = string.Format("I love {0}. \nI am also very Passionate about {1}. \nSo it only stands to reason I would want to be a {2}\n", Hobby, Passion, DreamJob);
            Output(ProfileDesc);
        }

        public void Introduce()
        {
            //Standard concatination.
            Output("Hello my name is: " + FirstName + " " + LastName + "\nI am " + Age + " years old and weigh: " + Weight + " lbs.");
            Description();
            Email();
        }
    }
}
