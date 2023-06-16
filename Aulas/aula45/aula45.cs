using System;

class Mat
{
    public static double pi = 3.14;

    public static double Dobro(int n)
    {
        return n * 2;
    }
}

class Aula45
{
    public static void Main(string[] args)
    {
        double vpi = Mat.pi;
        int num = 10;

        Console.WriteLine("VPI: {0}", vpi);
        Console.WriteLine("DOBRO: {0}", Mat.Dobro(num));
    }
}