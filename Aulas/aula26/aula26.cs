using System;

class Aula26
{
    static void Main(string[] args)
    {
        Console.WriteLine(Sum());
        Console.WriteLine(Sum(1, 2, 3, 4, 5));
    }

    static int Sum(params int[] sum)
    {
        int res = 0;

        if(sum.Length==0)
        {
            return res;
        }
        else
        {
            for(int i=0; i < sum.Length; i++)
            {
                res += sum[i];
            }
            return res;
        }
    }
}