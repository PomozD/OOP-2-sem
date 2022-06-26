using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab01_2
{
    class Student: IComparable<Student>,IComparer<Student>
    {
        public int group;
        public int course;
        public string name;
        private string[] arrayOfNames = new string[15]
        {
            "Pavel", "Alex", "Dasha", "Danik", "Anna", "Nastya", "Maksim", "Dima", "Polina", "Diana", "Sasha", "Masha", "Petya","Liza","Nika"
        };

        public Student()
        {
            Random random = new Random();
            Thread.Sleep(20);
            this.course = (int)random.Next(1, 5);
            this.group = (int)random.Next(1, 11);
            this.name = arrayOfNames[random.Next(0, 15)];
        }

        public int Compare(Student st1, Student st2)
        {
            return st2.CompareTo(st1);
        }

        public int CompareTo(Student student)
        {
            if (student == null)
            {
                return 1;
            }
            else
            {
                if (this.course > student.course)
                {
                    return 1;
                }
                else if (this.course < student.course)
                {
                    return -1;
                }
                else
                {
                    if (this.group > student.group)
                    {
                        return 1;
                    }
                    else if (this.group < student.group)
                    {
                        return -1;
                    }
                    else
                    {
                        return this.name.CompareTo(student.name);
                    }
                }
            }
        }
    }
}
