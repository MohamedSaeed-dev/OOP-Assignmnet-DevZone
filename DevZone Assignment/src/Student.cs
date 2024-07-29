using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevZone_Assignment.src
{
    public class Student : Person
    {
        private static int autoIncrementId; // a field for incrementing id automatically
        private int _grade;
        public int Grade
        {
            get { return _grade; }
            set
            {
                // Grade should be more than 0 and less than 100
                if (value < 0 || value > 100) return;
                _grade = value;
            }
        }
        public Student()
        {
            // auto increment id
            Id = ++autoIncrementId;
        }
        public override int Age 
        { 
            get => base.Age; 
            set
            {
                // student age must bigger than 6 and smaller than 30
                if (value < 6 || value > 30) return;
                base.Age = value;
            } 
        }
        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $"Grade: {Grade}\n";
        }
    }
}
