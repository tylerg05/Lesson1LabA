using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1LabA
{
    public class Teacher : Person, Talkable
    {
    private int age;

    public Teacher(int age, string name) : base(name)
    {
        this.name = name;
        this.age = age;
    }

    public int getAge()
    {
        return age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public string talk()
    {
        return "Don't forget to do the assigned reading!";
    }

    public string toString()
    {
        return "Teacher: " + "name=" + name + " age=" + age;
    }
    }
}
