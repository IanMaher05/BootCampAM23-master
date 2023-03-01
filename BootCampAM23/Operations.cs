using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public static class Operations
    {
        public static void Arithmetic()
        {
            //Use the debugger to see the values
            int a = 9;
            int b = 6;
            int c;

            a++; //Increment operator
            b--; //Decrement operator 

            // a = 10, b = 5
            c = a + b; //15
            c = a - b; //2
            c = a * b; //50
            c = a / b; //2

            

            c = a % b; //Modulo Operator... it will give you the REMAINDER of a/b
            // n % 2... is used to determine ODD or EVEN

            //a = 10, b = 5
            a += b;  //a=15
            a -= b;  //a=10
            a *= b;  //a=50
            a /= b;  //a=10
            a /= 6;  //a=1.... it TRUNCATES!!!! (it chops the decimal off without rounding)
           
        }

        public static void Comparisons()
        {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b); // == used for equality   (= means "assign" ) False
            Console.WriteLine(a != b); // != not equal   "!" bang   #!  "shabang"
            Console.WriteLine(a < b);  // <, >, <=, >=
            Console.WriteLine(b > c);

        }

        public static void Logic()
        {
            bool hasWeapon = true;
            bool hasMagic = false;
            bool hasArmor = false;

            bool isStrongOffense = hasWeapon && hasMagic; // TT->T   TF->F  FT->F  FF->F   AND &&
            Console.WriteLine("Is Strong Offense: {0}", isStrongOffense);

            bool isOKForBattle = hasWeapon || hasArmor || hasMagic;  //  TT->T   TF->T   FT->T  FF->F   OR ||
            Console.WriteLine("Is OK for Battle: {0}", isOKForBattle);

            //The NOT operator...
            Console.WriteLine(!hasWeapon); // used for toggling   T->F,   F->T

            //The XOR operator...   TT->F    TF->T     FT->T     FF->F  
            // "exclusive OR"
            bool mediumOffense = hasWeapon ^ hasMagic;
            Console.WriteLine("Has mediocre offense: {0}", mediumOffense);

        }

        public static void Ternary()
        {
            int a, b, c;
            a = 19;
            b = 5;

            c = (a > b) ? a : b;  //Cryptic ternary operator...  (One line if statetment)
            Console.WriteLine(c);

            //Equivalent:
            if (a > b)
            {
                c = a;
            } else
            {
                c = b;
            }

            int n = 8;
            string output = (n % 2 == 0) ? "EVEN" : "ODD";
            Console.WriteLine("{0} is {1}", n, output);

        }


    }
}
