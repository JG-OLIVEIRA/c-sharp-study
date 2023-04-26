using System;

class Aula14{
    static void Main (){

        int tempo=0;
        char escolha=' ';

        Console.WriteLine("Rio de Janeiro - RJ a Minas Gerais - MG");
        Console.WriteLine("Escolha um transporte: [a]Avião | [c] Carro | [o] Ônibus");

        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'A':
            case 'a':
                tempo=50;
                break;
            case 'C':
            case 'c':
                tempo=480;
                break;
            case 'O':
            case 'o':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;
        }

        if(tempo<0){
            Console.WriteLine("Transporte indisponível!");
        }else{
            Console.WriteLine("Tempo para o transporte escolhido é {0} minutos", tempo);
        }

    }
}