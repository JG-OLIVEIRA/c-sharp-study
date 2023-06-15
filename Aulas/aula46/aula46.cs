using System;

delegate int Op(int a, int b);

class Mat
{
    public static int Soma(int a, int b)
    {
        return a + b;
    }

    public static int Mult(int a, int b)
    {
        return a * b;
    }
}
class Aula46
{
    static void Main(string[] args)
    {
        int res;

        Op d1 = new Op(Mat.Soma);

        res = d1(10, 50);

        Console.WriteLine("Soma: {0}", res);

        d1 = new Op(Mat.Mult);

        res = d1(10, 50);

        Console.WriteLine("Multiplicação: {0}", res);
    }
}