using System;
using System.Collections;

namespace Lesson1LabA
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach (Talkable thing in zoo)
            {
                Console.WriteLine(thing.toString());
            }
        }
    }
}
