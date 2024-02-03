using System;

class Program
{
    static void Main()
    {
        Child c = new Child();
        Parent p = c;
       
        p.MethodParent();
        // Downcasting (Explicit)
        Child child = (Child)p;
        child.MethodParent();
        child.MethodChild();
    }
}

public class Parent
{
    public void MethodParent()
    {
        Console.WriteLine("MethodParent");
    }
}

public class Child : Parent
{
    public void MethodChild()
    {
        Console.WriteLine("MethodChild");
    }
}
