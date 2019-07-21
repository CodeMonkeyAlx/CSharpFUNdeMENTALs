using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundementals.Demo
{
    public class Strings
    {
       static void Description(){
            var Hobby = "gaming";
            var Passion = "Coding";
            var DreamJob = "Game Development";
            var ProfileDesc = string.Format("Hello there people. \nI love {0}. \nI am also very Passionate about {1}. \nSo it only stands to reason I would want to be a {2}", Hobby, Passion, DreamJob);
            Console.WriteLine(ProfileDesc);
        }
    }
}
