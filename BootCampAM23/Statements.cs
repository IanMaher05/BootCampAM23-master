using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public static class Statements
    {
        public static void BranchingIf()
        {

            int a = 42; //Try changing this...

            if (a <  4)  //Notice... no ;
            { //code block between {}
                Console.WriteLine(" a is less than 4");
                Console.WriteLine("================================");
            } else if (a >=4 && a <= 10)
            {
                Console.WriteLine("a is between 4 and 10 (inclusive)");
                Console.WriteLine("************************************");
            } else
            {
                Console.WriteLine("a is larger than 10.......  ");
                Console.WriteLine("++++++++++++++++++++++++++");
            }

            //A small wrinkle with if statements...
            int b = 20;
            if (b < 10)  
                Console.WriteLine("b is less than 10");
            //If there is ONLY one line of code that needs to run... no {} are needed!!!!

        }

        public static void Switching()
        {
            int d = 9; //Try changing this....
            string day = "";

            switch (d%7) //no ; here!!!!
            {
                case 1: //notice it's a : not a ;
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                default:
                    day = "a weekend day";
                    break;
            }
            Console.WriteLine("Day {0} is {1}", d, day);
        }

        public static void ForLoop()
        {
            // for (initializer; test-expression; updater) { }
            for(int i = 0; i < 10; i++)   //Count up by ones from 0 to 9
            {
                Console.WriteLine("i={0}", i);
            }

            //Nested For Loops...you will see it in the MiniDC...

        }

        public static void WhileLoops()
        {
            //  while (test-expression==true) { }
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i={0}", i);
                i++;
            }

            //do-while loop   Testing takes place AFTER the statements...
            int j = 0;
            do
            {
                Console.WriteLine("j={0}", j);
                j++;
            } while (j < 5);

            //Real use of do-while.... processing user input
            do
            {
                Console.Write("Command: > ");

            } while (Console.ReadLine() != "q");

        }

        public static void ForEachLoops()
        {
            List<string> phones = new List<string>();
            phones.Add("iPhone 14");
            phones.Add("Samsung Galaxy");
            phones.Add("Motorola Stylus");
            phones.Add("Google Pixel");
            phones.Add("t-Mobile Flip Phone");
            phones.Add("Nokia");
            phones.Sort();
            phones.Remove("Nokia");

            foreach(string p in phones)
            {
                Console.WriteLine("You take out your {0}", p);
            }

        }


    }
}
