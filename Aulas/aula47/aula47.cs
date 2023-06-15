using System;

class Aula47
{
    public static void Main(string[] args)
    {
        int res = 0;

        if (args.Length > 0)
        {
            Console.WriteLine("Qtd de argumentos: {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                res += Convert.ToInt32(args[i]);
            }
            Console.WriteLine("Resultado da soma: {0}", res);
        }
        else
        {
            Console.WriteLine("Não foram passados argumentos!!");
        }
    }
}