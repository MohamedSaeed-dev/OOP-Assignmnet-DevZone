using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevZone_Assignment.src
{
    public abstract class Person
    {
        private int _id;
        private string _name { get; set; }
        private int _age { get; set; }

        public int Id
        {
            get { return _id; }
            protected set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                // Name should not contain anything except letters
                for(int i = 0; i < value.Length;  i++)
                {
                    if (!char.IsLetter(value[i]))
                        return;
                }
                _name = value;
            }
        }
        public virtual int Age
        {
            get { return _age; }
            set
            {
                // Age should be more than 5 or less than 60
                if (value < 6 || value > 60) return;
                _age = value;
            }
        }

        public virtual string DisplayInfo()
        {
            return $"Id: {Id}\nName: {Name}\nAge: {Age}\n";
        }
    }
}
