using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1LabA
{
    public class Dog : Pet, Talkable
    {
        private bool friendly;

        public Dog(bool friendly, string name) : base(name)
        {
            this.name = name;
            this.friendly = friendly;
        }

        public bool isFriendly()
        {
            return friendly;
        }

        public string talk()
        {
            return "Bark";
        }

        public string toString()
        {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }


    }
}
