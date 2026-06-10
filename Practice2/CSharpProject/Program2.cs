using System;
using System.Collections.Generic;

namespace CSharpProject
{
    internal class Program2
    {

        public String getVoid()
        {
            return "shabalabadoo";
        }

        static void Main(String [] args)
        {
            Program test = new Program("fly", 1);
            Console.WriteLine(test.getCode());
        }
    }
}