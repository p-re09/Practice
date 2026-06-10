// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CSharpProject
{
    internal class Program{

        string part;
        int weight;

        public Program(string x, int y){
            part = x;
            weight = y;
        }

        public String getCode(){
            int testInt = 9;
            int testInt2 = 0;
            /**if (testInt < testInt2) {
                Console.WriteLine(testInt2);
            }
            else if (testInt > testInt2) {
                Console.WriteLine(testInt);
            }
            else {
                Console.WriteLine("-------");
            }

            return " ";**/

            /**switch (testInt) {
                case 9:
                    Console.WriteLine(testInt + "---");
                    break;
                case 10:
                    Console.WriteLine(testInt + "***");
                    break;
                case 12:
                    Console.WriteLine(testInt + "===");
                    break;
            }**/

            /**for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }**/

            /**while (testInt > testInt2) {
                Console.WriteLine(testInt2);
                testInt2++;
            }**/

            //String [] testArray = new String[3];
            //testArray = ["je", "dd", "ew"];
            //testArray = ["je", "dd"];
            //testArray[0] = "oo";
            //testArray = ["je", "dd", "ew", "efrtgeqf", "ergwq3fg", "frgwq"];

            List <String> testList = new List<String>();
            testList = ["rthjthrgef,", "rrgtbhrgfe"];
            testList.Add("feewrefg");
            testList.Remove("feewrefg");

            foreach (string str in testList){
                Console.WriteLine(str);
            }

            return "12345";
        }

        static void Main(String [] args){
            Program myProgram = new Program("window", 150);
            Console.WriteLine(myProgram.getCode());
        }
    }
}