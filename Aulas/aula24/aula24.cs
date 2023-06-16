using System;

class Aula24
{
    static void Main()
    {
        int num=10;
        Double(num);
        Console.WriteLine(num);
    }

    static void Double(int value)
    {
        value*=2;
    }

    static void Double(ref int value)
    {
        value*=2;
    }
}