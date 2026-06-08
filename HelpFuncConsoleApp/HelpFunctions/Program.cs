// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFuncConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = "string";
            int y = 1;
            bool boolTest = true;

            if (boolTest == true)
            {
                //Console.WriteLine(x + " " + boolTest);
            }
            else if (boolTest == false)
            {
                //Console.WriteLine(x + " " + boolTest);
            }
            else
            {
                //Console.WriteLine(y + " " + boolTest);
            }

            /**Console.WriteLine("Input a number between 1 and 4 and press Enter");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("You selected 1");
                    break;
                case 2:
                    Console.WriteLine("You selected 2");
                    break;
                case 3:
                    Console.WriteLine("You selected 3");
                    break;
                case 4:
                    Console.WriteLine("You selected 4");
                    break;
            }**/

            //for (int i = 0; i < 5; i++)
            //{
            //   Console.WriteLine(i);
            //}

            int q = 0;
            int j = 10;

            //while (q < j)
            //{
                //Console.WriteLine(q);
            //    q++;
            //}

            string [] strArray = new string[3];
            strArray = ["couch", "bed", "chair"];

            //foreach (string str in strArrray)
            //{
                //Console.WriteLine(str);
            //}

            List <String> colour = strArray.ToList();
            //List <String> colour = new List<string>();

            colour.Add("red");
            colour.Add("blue");
            colour.Add("green");
            colour.Add("magenta");
            colour.Add("indigo");
            colour.Add("purple");
            colour.Add("cyan");
            colour.Add("beige");
            colour.Add("blue");

            colour.Remove("red");
            colour.Sort();
            colour.Reverse();
            //Console.WriteLine(colour.IndexOf("blue"));
            //Console.WriteLine(colour.LastIndexOf("blue"));

            //foreach (string c in colour)
            //{
            //    Console.WriteLine(c);
            //}

            String house = "chair is comfy with an execptional mattress";
            String i = "On a very comfy ";
            i = house + "fgewf";
            Console.WriteLine(i);
        }
    }
}


