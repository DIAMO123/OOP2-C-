﻿using System;

namespace Test
{
    class Program
    {
        static void greet(string name)
        {
            Console.WriteLine("Welcome to C# class " + name);
        }
        static int add(int a, int b)
        {
            return (a + b);
        }
        static void CallByReference(ref int val)
        {
            val += val;//val=val+val;
            Console.WriteLine("Vaalue is : " + val);
        }

        static void outFunction(out int insidevar)
        {
            insidevar = 0;
            insidevar = insidevar + 50;
            Console.WriteLine("Out value :  " + insidevar);
        }
        static void add(params int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            // this is single line comment
            /*
             this is multi-line comment
             */
            //int value = 10; --> 4 bytes
            //long value = 100; ---> 8 bytes
            //float value = 10.5F; ---> 4 bytes
            //double value = 10.5; -----> 8 bytes
            //char A = 'b'; ------> 2 bytes
            //bool istrue = true; ----> 1 bits
            //String a = "This is a string";// ---> 2 bytes per character

            //float bb = 3.5F;
            //Console.WriteLine(a);

            //string input = Console.ReadLine();
            //Console.Write(input);


            //Console.Write("Hello world");
            //string value = Console.ReadLine();
            //Console.WriteLine("Value is " + value);
            //Console.Write("C#");
            //Console.WriteLine("The value is: " + istrue);


            //Type casting
            /*There are two types of tyoe casting
            1. implicit casting
            Char to int to long to float to double
            2. explicit casting
            */

            //int a = 3;
            //double b = a;
            //int c = 'y';
            //char d = c;
            //Console.WriteLine(b);

            // int a = (int)bb;
            // Console.WriteLine(a);
            //double x1 = (double)55;
            //Console.WriteLine(x1);

            //float val = Convert.ToInt32(3.55); //built in method 

            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi Hello " + name);
            //Console.WriteLine("How many burgers do you want");
            //string value = Console.ReadLine();
            //Console.WriteLine("You have got One extra " + (Convert.ToDouble(value) + 1));
            ////Console.WriteLine("You have got one extra" + value + 1);


            // greet("NILOY");
            // Console.WriteLine(add(4, 4));


            /* operator
             * Arthmetic
             * Assignment
             * logical
             * Comparison
             * 
            */

            // Arithmetic operatior
            //int a = 6;
            //int b = 3;
            //Console.WriteLine("A + B " + (a + b));
            //Console.WriteLine("A - B " + (a - b));

            //Assignment
            //int c = 3;
            //int d = c;
            //d += 4;
            //Console.WriteLine(d);

            //logical
            // Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(!true);
            //Convert.ToDouble()

            //Comparison
            //Console.WriteLine(34 > 45);
            //Console.WriteLine(34 <= 45);
            //Console.WriteLine(34 >= 45);
            //Console.WriteLine(34 != 45);
            //Console.WriteLine(34 == 45);
            // 

            //String interpolation
            /* string Company = "Software";
            string Department = "IT";
            string Info = $"My full name is: {Company} {Department}";
            Console.WriteLine(Info);
            */
            //IF else Condition
            //Console.WriteLine("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("It is even number");
            //}
            //else
            //{
            //    Console.WriteLine("It is odd number");
            //}
            //// switch
            //switch (num)
            //{
            //    case 1: Console.WriteLine("Case 1"); break;
            //    case 2: Console.WriteLine("Case 2"); break;
            //    case 3: Console.WriteLine("Case 3"); break;
            //    default:
            //        Console.WriteLine("Not 1, 2 or 3"); break;
            //}
            //For
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine(i + " " + j);
            //    }

            //}
            //call by reference
            //int a = 20;
            // CallByReference(ref a);
            // Console.WriteLine(a);

            //Out
            //int outvalue = 20;
            //Console.WriteLine(outvalue);
            //outFunction(out outvalue);
            //Console.WriteLine(outvalue);

            //Params
             //add(12, 13, 10, 15, 56, 76, 89);

            //string[] city = { "dhaka", "Chittagong", "Rajshahi", "Mymensigh" };
            //foreach(string i in city)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
            }
        }
    
}
