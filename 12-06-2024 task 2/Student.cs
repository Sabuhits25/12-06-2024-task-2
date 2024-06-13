using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_2024_task_2
{

    public class Student
    {
        private static int studentIdCounter = 1;
        private readonly int id;
        public string Fullname { get; set; }
        public float Point { get; set; }

        public Student(string fullname, float point)
        {
            this.id = studentIdCounter++;
            this.Fullname = fullname;
            this.Point = point;
        }

        public int Id => id;

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Point: {Point}");
        }
    }
}
