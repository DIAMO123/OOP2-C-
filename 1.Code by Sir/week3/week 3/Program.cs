﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Box
    {
        private double height;
        public double width;

        public void setHeight(double h)
        {
            height = h;
        }
        public double getHeight()
        {
            return height;
        }

        //properties
        /*public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }*/
        public  void area()
        {
            Console.WriteLine(height * width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[5];
            //arr[0] = 20;
            //arr[1] = 25;
            //arr[2] = 30;

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] arr1 = new int[5] {1,4,2,3,5};
            //int[] arr2 = new int[] { 1, 4, 2, 3, 5 };

            int[,] multiArr = new int[2, 3] { { 4, 3, 6 }, { 5, 4, 7 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(multiArr[i, j] + "\t ");
                }
                Console.WriteLine();
            }

            /*int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3] { 6, 4, 2 };
            jaggedArray[1] = new int[2] { 50, 30 };
            jaggedArray[2] = new int[4] { 11, 12, 44, 22 };


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+" ");
                }
                Console.WriteLine();
            }

            foreach (int[] arra in jaggedArray)
            {
                foreach (int item in arra)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }*/

            Box obj = new Box();
            obj.width = 10.3;
            //obj.Height = 10.4;
           obj.setHeight(10.4);
            obj.getHeight();
            //Console.WriteLine(obj.getHeight());
            //obj.width = 12.4;
            //obj.area();
             
             

            //Console.WriteLine(obj.Height);


            Console.ReadKey();

        }
    }
}
