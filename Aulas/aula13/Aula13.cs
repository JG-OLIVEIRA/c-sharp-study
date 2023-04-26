using System;

class Aula13{
    static void Main(){

        int p1, p2, media;
        p1=p2=media=0;
        string resultado = "Aprovado";

        Console.Write("Digite a P1: ");
        p1=int.Parse(Console.ReadLine());
        
        Console.Write("Digite a P2: ");
        p2=int.Parse(Console.ReadLine());

        media=(p1+p2)/2;

        if(media<40){
            resultado="Reprovado";
        } else if(media<60){
            resultado="Recuperação";
        }else{
            resultado="Aprovado";
        }

        Console.WriteLine("Média: {0} - Resultado: {1}", media, resultado);
    }
}