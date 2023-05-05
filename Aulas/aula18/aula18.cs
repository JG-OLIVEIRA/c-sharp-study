using System;

class Aula18
{
    static void Main()
    {
        for(int num=0;num<10;num++)
        {
            Console.WriteLine("CFB CURSOS {0}", num);
        }

        Console.WriteLine("");

        int[] numbers = new int[10];

        for(int i=0;i<numbers.Length;i++)
        {
            numbers[i] = 2 * i;
        }

        for(int i=0;i<numbers.Length;i++)
        {
            Console.WriteLine("Valor: {0}", numbers[i]);
        }
    }
}