// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace HelpFuncConsoleApp
{

    interface ISound
    {
        public string getAnimal();
    }
    interface ISound2
    {
        public string getAnimalNoise();
    }

    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
            
        }
    }

    class MyException2 : Exception
    {
        public int CurrentBalance {get;}
        public MyException2(string message, int balance) : base(message)
        {
            CurrentBalance = balance;
        }
    }

    internal class Program : ISound, ISound2
    {

        public string getCode()
        {
            return "dfgf";
        }

        public int transaction(int withdrawalAmount)
        {
            int balance = 500;
            if (withdrawalAmount > balance)
            {
                throw new MyException2("Insufficient funds", balance);
            }
            balance -= withdrawalAmount;

            return balance;
        }

        public char myString(int [] j, int o)
        {
            if (o > j.Length)
            {
                throw new MyException("Out of Bounds");
            }
            Console.WriteLine("It worked");
            return ' '; 
        }

        public string heHeeee(int i, string j)
        {
            //string [] myArray = new string[3];
            //myArray = ["eregrre","rftgrf","rfgtrfeerf","erger", "regtrter"];
            //string myString = myArray[10];

            if (i > j.Length)
            {
                //throw new ArithmeticException("Not in bounds");
                //throw new IndexOutOfRangeException("Not in bounds");
                throw new NullReferenceException("Not in bounds");
            }
            else
            {
                Console.WriteLine("hehee");
            }
            return " ";
        }

        public string getAnimal()
        {
            return "flamingo";
        }

        public string getAnimalNoise()
        {
            return "heheeeeee";
        }

        
        static void Main(string[] args)
        {

            Program test = new Program();

            try
            {
                test.transaction(700);
            }
            catch (MyException2 ex)
            {
                Console.WriteLine($"{ex.Message} bla bla bla {ex.CurrentBalance}");
            }








            /**try
            {
                test.myString([1,2,3,4], 3);
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Yes sir");
            }**/








            /**try
            {
                Console.WriteLine(test.heHeeee());
            }
            catch (Exception e)
            {
                Console.WriteLine("String not valid");
            }
            finally
            {
                Console.WriteLine("String still not valid");
            }**/
            //Console.WriteLine(test.heHeeee(100, "jaywalk"));
            //Console.WriteLine(test.heHeeee(100, ""));
            //Console.WriteLine(test.getAnimal() + " " + test.getAnimalNoise());
            //var x = "string";
            //int y = 1;
            //bool boolTest = true;

            /**if (boolTest == true)
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
            }**/

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

            //int q = 0;
            //int j = 10;

            //while (q < j)
            //{
                //Console.WriteLine(q);
            //    q++;
            //}

            //string [] strArray = new string[3];
            //strArray = ["couch", "bed", "chair"];

            //foreach (string str in strArrray)
            //{
                //Console.WriteLine(str);
            //}

            //List <String> colour = strArray.ToList();
            //List <String> colour = new List<string>();

            //colour.Add("red");
            //colour.Add("blue");
            //colour.Add("green");
            //colour.Add("magenta");
            //colour.Add("indigo");
            //colour.Add("purple");
            //colour.Add("cyan");
            //colour.Add("beige");
            //colour.Add("blue");

            //colour.Remove("red");
            //colour.Sort();
            //colour.Reverse();
            //Console.WriteLine(colour.IndexOf("blue"));
            //Console.WriteLine(colour.LastIndexOf("blue"));

            //foreach (string c in colour)
            //{
            //    Console.WriteLine(c);
            //}

            //String house = "chair is comfy with an execptional mattress";
            //String i = "On a very comfy ";
            //i = house + "fgewf";
            //Console.WriteLine(i);
        }
    }
}


