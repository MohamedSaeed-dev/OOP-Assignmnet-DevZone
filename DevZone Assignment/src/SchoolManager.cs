using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevZone_Assignment.src
{
    public class SchoolManager : Manageable
    {
        private static List<Teacher> teachers = new List<Teacher>();
        private static List<Student> students = new List<Student>();

        public override void AddStudent(Student person)
        {
            if (person == null) return;
            students.Add(person);
        }

        public override void AddTeacher(Teacher person)
        {
            if (person == null) return;
            teachers.Add(person);
        }

        public override void DeleteStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null) return;
            students.Remove(student);
        }

        public override void DeleteTeacher(int id)
        {
            var teacher = teachers.Find(x => x.Id == id);
            if (teacher == null) return;
            teachers.Remove(teacher);
        }

        public override void UpdateStudent(int id, Student person)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null) return;
            
            if(!string.IsNullOrEmpty(person.Name)) student.Name = person.Name;
            if(person.Age != 0) student.Age = person.Age;
            if(person.Grade != 0) student.Grade = person.Grade;
        }

        public override void UpdateTeacher(int id, Teacher person)
        {
            var teacher = teachers.Find(x => x.Id == id);
            if (teacher == null) return;

            if (!string.IsNullOrEmpty(person.Name)) teacher.Name = person.Name;
            if (person.Age != 0) teacher.Age = person.Age;
            if (!string.IsNullOrEmpty(person.Subject)) teacher.Subject = person.Subject;
        }

        public override string ViewAll()
        {
            var all = "========Teachers=======\n";
            foreach (var teacher in teachers)
            {
                all += teacher.DisplayInfo() + "\n";
            }
            all += "========Students=======\n";
            foreach (var student in students)
            {
                all += student.DisplayInfo() + "\n";
            }
            return all;
        }

        public override string ViewStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null) return "No Student";
            return student.DisplayInfo();
        }

        public override string ViewTeacher(int id)
        {
            var teacher = teachers.Find(x => x.Id == id);
            if (teacher == null) return "No Student";
            return teacher.DisplayInfo();
        }
    }
}
