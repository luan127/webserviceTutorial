using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.DataBase
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Gener { get; set; }
        public string Email { get; set; }
        public Student() { }
        public Student(int id, string name, int gener, string email)
        {
            this.ID = id;
            this.Name = name;
            this.Gener = gener;
            this.Email = email;
        }
        public List<Student> AllStudents()
        {
            var students = new List<Student>();
            var s1 = new Student(1, "Tran Cong Luan", 1, "luan@gmail.com");
            students.Add(s1);
            var s2 = new Student(2, "Tran Cong Lap", 1, "lap@gmail.com");
            students.Add(s2);
            var s3 = new Student(3, "Tran Ha Bang", 0, "bang@gmail.com");
            students.Add(s3);
            var s4 = new Student(4, "Tran Linh Chi", 1, "chi@gmail.com");
            students.Add(s4);
            var s5 = new Student(5, "Tran Anh Tu", 1, "luan@gmail.com");
            students.Add(s5);
            return students;
        }

    }
}