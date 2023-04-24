using System;

class Aula04{

   
    static void Main(){
        int n1, n2, n3;

        n1=10;n2=20;n3=30;  

        Console.Write("n1={0}\nn2={1}\nn3={2}\n", n1, n2, n3);


        // mais exemplos

        Console.WriteLine("");
        Console.WriteLine("Mais exemplos");
        Console.WriteLine("");

        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";

        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto..........:{0,15}", produto);
        Console.WriteLine("Val.Compra.......:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro............:{0,15:p}", lucro);
        Console.WriteLine("Val.Venda........:{0,15:c}", valorVenda);
    }
}