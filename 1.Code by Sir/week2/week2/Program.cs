﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    struct student
    {
        public int studentId;
        public string studentName;

        public void getId(int id)
        {
            Console.WriteLine("Student id is: " + id);
        }

        public int id
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
            //set;
            //get;
        }

        public student(int id, string name)
        {
            studentId = id;
            studentName = name;
        }

        public void showInfo()
        {
            Console.WriteLine("Student id is: " + studentId + "\n" + "Student Name is: " + studentName);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            //student s1 = new student(2, "joy");
            //student s1;
            //s1.id = 3;
            //student s1;
            //s1.studentId = 2;
            //s1.studentName = "Joy";

            //s1.getId(s1.id);
            
            //s1.showInfo();

           
            


            Console.ReadKey();
        }
    }
}
