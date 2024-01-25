class Program
{
    static void Main()
    {
        Child c = new Child(1, 2, 3, 4);
        Parent p = c;

        //Console.WriteLine(p.a);

        //Console.WriteLine(p.b);


        Parent p1 = new Child(1, 2, 3, 4);

        Console.WriteLine(p1.a);

        Console.WriteLine(p1.b);
        //Console.WriteLine(p1.c);

        //Console.WriteLine(p1.d);




        //Console.WriteLine(c.a);
        //Console.WriteLine(c.b);
        //Console.WriteLine(c.c);
        //Console.WriteLine(c.d);




        //Parent p1 = new Parent(1, 2);
        //Child c1 = p1; 


    }
}

class Parent
{
    public int a;
    public int b;
    public Parent(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}
class Child : Parent
{
    public int c;
    public int d;
    public Child(int a, int b, int c, int d) : base(a, b)
    {
        this.c = c;
        this.d = d;
    }
}
