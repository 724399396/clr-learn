using System;

class  SomeRef { public Int32 x; }

struct SomeVal { public Int32 x; }

class Program
{
    static void ValueTypeDemo()
    {
        SomeRef r1 = new SomeRef();
        SomeVal v1 = new SomeVal();
        r1.x = 5;
        v1.x = 5;
        Console.WriteLine(r1.x);
        Console.WriteLine(v1.x);

        SomeRef r2 = r1;
        SomeVal v2 = v1;
        r1.x = 8;
        v1.x = 9;
        Console.WriteLine(r1.x);
        Console.WriteLine(r2.x);
        Console.WriteLine(v1.x);
        Console.WriteLine(v2.x);

    }

    static void Main()
    {
        ValueTypeDemo();
    }
}
