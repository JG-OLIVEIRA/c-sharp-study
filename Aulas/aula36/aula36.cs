using System;

abstract class Veiculo
{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    public int getVelAtual()
    {
        return velAtual;
    }

    abstract public void aceleracao(int mult);
}

class Carro : Veiculo
{
    public Carro()
    {
        velMax = 120;
    }

    public override void aceleracao(int mult)
    {
        velAtual += 10 * mult;
    }
}

class Aula36
{
    static void Main()
    {
        Carro c1 = new Carro();

        c1.aceleracao(1);

        Console.WriteLine(c1.getVelAtual());
    }
}