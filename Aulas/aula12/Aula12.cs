using System;

class Aula12
{
    static void Main()
    {
        int p1, p2, res;
        p1=p2=res=0;
        string resultado="Reprovado";

        Console.Write("Digite a P1: ");
        p1=int.Parse(Console.ReadLine());
        
        Console.Write("Digite a P2: ");
        p2=int.Parse(Console.ReadLine());

        res=p1+p2;

        if(res>=120){
            resultado="Aprovado";
        }

        Console.WriteLine("Resultado: {0}", resultado);
    }
}