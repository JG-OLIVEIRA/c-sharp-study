using System;

class Veiculo
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public int getVelMax()
    {
        return velMax;
    }

    public bool getLigado()
    {
        return ligado;
    }
}

class Carro : Veiculo // derivada de Veiculo
{
    public string nome;

    public Carro(string nome, int velMax) : base(velMax)
    {
        this.nome = nome;
        ligado = true;
    }
}

class Aula34
{
    static void Main()
    {
        Carro carro = new Carro("Bonitão", 120);

        Console.WriteLine("Nome.............:{0}", carro.nome);
        Console.WriteLine("Vel.Máxima.......:{0}", carro.getVelMax());
        Console.WriteLine("Ligado...........:{0}", carro.getLigado());
    }
}