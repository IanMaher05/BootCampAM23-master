using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public static class Storing //static means it only holds code... not for an object!
    {
        //Making a method...
        public static void DemoVariables()
        {
            int employeeID = 42; //whole numbers, no decimals
            uint income = 78; //unsigned.... only positive!
            long bigNumber = 347892378792347982;
            float pi = 3.14159f;  //can also use double or decimal
            string employeeName = "Jim"; //store up to 2GB
            bool isRich = false; //true or false
            char firstInitial = 'J';

            income++;
            firstInitial++;
         
            Console.WriteLine("Your name is {0} and your first initial is {1} and your income is {2}", employeeName, firstInitial, income);
           
        }

        public static void ReadingInput()
        {
            Console.Write("What is your name? ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Hello {0}. Welcome to Microsoft!", employeeName);
            Console.Write("How old are you? (In Years): ");
            int age =  Convert.ToInt32 ( Console.ReadLine()) ;
            Console.WriteLine("You are {0} years old.",age);
            int ageInMonths = age * 12;
            Console.WriteLine("You are {0} months old.",ageInMonths);

            //Variable names...
            //   camelCaseVariableName   (first letter lowercase... the rest begin with UC)
            //   PascalCaseVariableName  (First letter UC, the rest begin with UC)

        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[5];
            enemyName[0] = "Creeper";
            enemyName[1] = "Logan the Lonely";
            enemyName[2] = "Jonathan the Joker sans appendix";
            enemyName[3] = "Tayton the Terrible";
            enemyName[4] = "Jim the Jubilant";

            int[] health = new int[5];
            health[0] = 20; //the creeper's health is 20
            health[1] = 5; //Logan the lonely has 5 health
            health[2] = 1;
            health[3] = 100;
            health[4] = 1000;

            System.Random random = new System.Random();

            while (true)
            {
                int num = random.Next(5); //select a random enemy

                Console.WriteLine(enemyName[num]);
                health[num]--;
                if (health[num] <= 0)
                {
                    Console.WriteLine("THEY ARE DEAD!!!!");
                }
                else
                {
                    Console.WriteLine("Health: {0}", health[num]);
                }

                Console.WriteLine();
                Console.ReadKey();
            }



        }

    }
}
