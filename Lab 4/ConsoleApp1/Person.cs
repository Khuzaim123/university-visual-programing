using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    protected string name;
    public Person() 
    {
        name = null;
    }
}

public class Student : Person
{
    private int id;
    private int age;
    private string dep;
    public Student()
    {
        id = 0;
        age = 0;
        dep = null;
    }

    public void setid(int id)
    {
        this.id = id;
    }

    public void setname(string name)
    {
        this.name = name;
    }

    public void setage(int age)
    {
        this.age = age;
    }

    public void setdep(string dep)
    {
        this.dep = dep;
    }

    public void display()
    {
        Console.WriteLine("Name = " + name);
        Console.WriteLine("ID = " + id);
        Console.WriteLine("Age = " + age);
        Console.WriteLine("Department = " + dep);
    }
}

