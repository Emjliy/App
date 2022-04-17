using System;
using System.Collections.Generic;
using System.Text;

namespace ManagmentApp
{
    class Student
    {
        public string FullName { get; set; }
        public string StudentGroupNo { get; set; }
        public Group _group;
        public bool Type { get; set; }
        public static List<Student> studs = new List<Student>();
        public Student()
        {
            bool isExist = false;
            Console.WriteLine("Type daxil et");
            Type = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Adi daxil et");
            FullName = Console.ReadLine();
            Console.WriteLine("QrupNo daxil et");
            StudentGroupNo = Console.ReadLine();
            foreach (var group in Group.groups)
            {
                if (group.GroupNo == StudentGroupNo)
                {
                    Console.WriteLine("Now You Can Add Student this existing Group");
                    _group = group;
                  
                }
            }
            if (isExist)
            {
                Console.WriteLine("yoxdu ");
            }

        }

        //public static void Add(Student student)
        //{
        //    Array.Resize(ref students, students.Length + 1);
        //    students[students.Length - 1] = student;
        //}
        public static void ShowAllStudents()
        {
            foreach (var item in studs)
            {
                Console.WriteLine($"{item.FullName} {item.StudentGroupNo}");
            }
        }



    }
}
