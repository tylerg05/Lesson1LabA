using System;
using System.Collections;

namespace Lesson1LabA
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objects = new ArrayList();

            UserInput newInput = new UserInput();

            Object newObject = newInput.returnObject();

            objects.Add(newObject);

            // Lines to Replace Begin Here
            //bjects.Add(new Dog(true, "Bean"));
            //objects.Add(new Cat(9, "Charlie"));
            //objects.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach (Talkable thing in objects)
            {
                Console.WriteLine(thing.toString());
            }
        }
    }
}
