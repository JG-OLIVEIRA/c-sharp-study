using System;

class Aula16{
    static void Main(){
        int[] n1=new int[5];
        int[] n2=new int[4]{55, 66, 77, 88};
        string[] veiculos=new string[3];

        veiculos[0]="carro";
        veiculos[1]="ônibus";
        veiculos[2]="caminhão";

        n1[0]=11;
        n1[1]=22;
        n1[2]=33;
        n1[3]=44;
        n1[4]=55;

        Console.WriteLine(n1[0]);
        Console.WriteLine(n2[0]);
        Console.WriteLine(n1[1]);
        Console.WriteLine(n2[1]);

        Console.WriteLine(veiculos[0]);
        Console.WriteLine(veiculos[1]);
        Console.WriteLine(veiculos[2]);
    }
}