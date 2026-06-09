using System;

namespace HelpFuncConsoleApp
{
    internal class Program2
    {
        int myX;
        int myY;
        public Program2(int x, int y)
        {
            myX = x + 1;
            myY = y + 2;
        }
        static void Main(String [] args)
        {
            //Program myProgram = new Program();
            //Console.WriteLine(myProgram.getCode());
            //var smoke = "wertyuiuytre";
            //Console.WriteLine(smoke);
            Console.WriteLine(new Program2(1, 2).myX);
        }
    }
}

    
