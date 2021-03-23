using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Lesson1LabA
{
    class UserInput
    {

        public UserInput()
        {
        }

        public string gatherInput()
        {
            Console.WriteLine("What animal would you like to create?");
            return Console.ReadLine();
        }

        public object instObject(string objectName)
        {
            if (objectName.Equals("Cat"))
            {
                Cat newObject = new Cat(4, "Fluffy");
                return newObject;
            }
            else if (objectName.Equals("Dog"))
            {
                Dog newObject = new Dog(true, "Fido");
                return newObject;
            }
            else if (objectName.Equals("Teacher"))
            {
                Teacher newObject = new Teacher(30, "Ms. Frizzle");
                return newObject;
            }
            else
            {
                Console.WriteLine("Object not found");
                return null;
            }
        }

        public object returnObject()
        {
            string newObjectName = gatherInput();
            object newObject = instObject(newObjectName);
            return newObject;
        }

    }
}
