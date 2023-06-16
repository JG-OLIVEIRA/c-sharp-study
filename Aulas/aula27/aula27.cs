using System;
using System.Threading;

class Conta
{
    public int numero;
    public string titular;
    public double saldo;

    public void Exibe(){
        Console.WriteLine("Informações da conta: ");
        Console.WriteLine("Número: {0}", this.numero);
        Console.WriteLine("Titular: {0} ", this.titular);
        Console.WriteLine("Saldo: {0}", this.saldo);
    }

    public bool Saca(double valor)
    {
        Console.WriteLine("Saldo: {0}", this.saldo);
        Console.WriteLine("Processando...");
        Thread.Sleep(1000);
        if(this.saldo >= valor){
            this.saldo -= valor;
            Console.WriteLine("Saldo atual: {0}", this.saldo);
            return true;
        }
        return false;
    }

    public void Transfere(double valor, Conta conta)
    {
        Console.WriteLine("Tranfererindo R${0} para {1} - {2}...", valor, conta.titular, conta.numero);
        Thread.Sleep(1000);
        if(Saca(valor))
        {
            conta.saldo += valor;
            Console.WriteLine("Tranferência concluída");
        }
        else
        {
            Console.WriteLine("Transferência mal sucedida");
        }
    }
}

class Aula27
{
    static void Main()
    {
        Conta c1, c2;

        c1 = new Conta();
        c2 = new Conta();

        c1.numero=13;
        c2.numero=17;

        c1.titular="Mario";
        c2.titular="Luiza";

        c1.saldo=1000;
        c2.saldo=200;

        Console.Clear();
        
        c1.Transfere(300, c2);

        Console.WriteLine("");
        c1.Exibe();
        Console.WriteLine("");
        c2.Exibe();
    }
}