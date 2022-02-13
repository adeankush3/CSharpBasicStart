using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramingCSharp
{
    internal class Basic
    {
        
        public void Base()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            //If Else
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
           
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            
            int time1 = 22;
            if (time1 < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time1 < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            //Case
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            //while Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            /*do While Loop
            int i2 = 0;
            do
            {
                Console.WriteLine(i2);
                i++;
            }
            while (i2 < 5);*/
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }

            for (int h = 0; h < 10; h++)
            {
                if (h == 4)
                {
                    break;
                }
                Console.WriteLine(h);
            }

            for (int a = 0; a < 10; a++)
            {
                if (a == 4)
                {
                    continue;
                }
                Console.WriteLine(a);
            }

            int z = 0;
            while (z < 10)
            {
                Console.WriteLine(z);
                i++;
                if (z == 4)
                {
                    break;
                }
            }
        }
    }
}
