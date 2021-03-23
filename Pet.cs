using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1LabA
{
    public abstract class Pet
    {
        protected string name;

        public Pet(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
