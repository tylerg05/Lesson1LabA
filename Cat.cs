﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1LabA
{
    public class Cat : Pet, Talkable
    {
        private int mousesKilled;

        public Cat(int mousesKilled, string name) : base(name)
        {
            this.name = name;
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled()
        {
            return mousesKilled;
        }

        public void addMouse()
        {
            mousesKilled++;
        }

        public string talk()
        {
            return "Meow";
        }

        public string toString()
        {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}


