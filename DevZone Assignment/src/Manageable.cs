using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevZone_Assignment.src
{
    public abstract class Manageable
    {
        public abstract string ViewAll();
        public abstract void AddStudent(Student person);
        public abstract void AddTeacher(Teacher person);
        public abstract string ViewStudent(int id);
        public abstract string ViewTeacher(int id);
        public abstract void UpdateStudent(int id, Student person);
        public abstract void UpdateTeacher(int id, Teacher person);
        public abstract void DeleteStudent(int id);
        public abstract void DeleteTeacher(int id);
    }
}
