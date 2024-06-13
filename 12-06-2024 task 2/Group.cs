using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_2024_task_2
{
    public class Group
    {
        public string GroupNo { get; private set; }
        public int StudentLimit { get; private set; }
        private Student[] Students;
        private int studentCount = 0;

        public Group(string groupNo, int studentLimit)
        {
            if (CheckGroupNo(groupNo) && studentLimit >= 5 && studentLimit <= 18)
            {
                this.GroupNo = groupNo;
                this.StudentLimit = studentLimit;
                this.Students = new Student[studentLimit];
            }
            else
            {
                Console.WriteLine("Invalid group number or student limit.");
            }
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
                return false;

            if (!char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1]))
                return false;

            for (int i = 2; i < 5; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                    return false;
            }

            return true;
        }

        public void AddStudent(Student student)
        {
            if (studentCount < StudentLimit)
            {
                Students[studentCount++] = student;
            }
            else
            {
                Console.WriteLine("Cannot add student, group is full.");
            }
        }

        public Student GetStudent(int id)
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            Student[] currentStudents = new Student[studentCount];
            Array.Copy(Students, currentStudents, studentCount);
            return currentStudents;
        }
    }

}

