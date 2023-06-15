using System;

class Calc
{
    public int Soma(params int[] x)
    {
        int res = 0;
        for (int i = 0; i < x.Length; i++)
        {
            res += x[i];
        }
        return res;
    }

    public double Soma(params double[] x)
    {
        double res = 0;
        for (int i = 0; i < x.Length; i++)
        {
            res += x[i];
        }
        return res;
    }

    public int Fat(int x)
    {
        if (x == 0 || x == 1)
        {
            return 1;
        }
        else
        {
            return x * Fat(x - 1);
        }
    }
}

class Aula47
{
    static void Main(string[] args)
    {
        Calc calc = new Calc();
        Console.WriteLine("Resultado da soma com double: {0}", calc.Soma(1.5, 2.7));
        Console.WriteLine("Resultado da soma com int: {0}", calc.Soma(10, 7));
        Console.WriteLine("Resultado do fatorial de 5!: {0}", calc.Fat(5));
    }
}