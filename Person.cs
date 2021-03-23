using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1LabA
{
    public abstract class Person
    {
        protected string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
