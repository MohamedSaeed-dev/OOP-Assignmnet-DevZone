using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DevZone_Assignment.src
{
    public class Teacher : Person
    {
        private static int autoIncrementId; // a field for incrementing id automatically
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set
            {
                // subject should not contain anything except letters
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                        return;
                }
                _subject = value;
            }
        }
        public Teacher()
        {
            // auto increment id
            Id = ++autoIncrementId;
        }

        public override int Age 
        { 
            get => base.Age; 
            set
            {
                // teacher age must be bigger than 23 and smaller than 60
                if (value < 23 || value > 60) return;
                base.Age = value;
            }
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $"Subject: {Subject}\n";
        }
    }
}
