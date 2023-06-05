using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }

    public virtual void Info()
    {
        Console.WriteLine("Método info da classe Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada 1");
    }

    public override void Info()
    {
        Console.WriteLine("Método info da classe Derivada 1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");
    }

}

class Aula35
{
    static void Main()
    {
        Base Ref;
        Derivada1 derivada1 = new Derivada1();

        Ref = derivada1;
        Ref.Info();
    }
}