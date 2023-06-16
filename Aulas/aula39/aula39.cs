using System;


public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro : Veiculo, Combate
{

    public bool ligado;
    private int municao;

    public Carro()
    {
        this.municao = 100;
    }

    public void setMonicao(int qtde)
    {
        this.municao = qtde;
    }

    public void ligar()
    {
        this.ligado = true;
    }

    public void desligar()
    {
        this.ligado = false;
    }

    public void disparar() { }

    public void info() { }

}

class Aula39
{
    static void Main()
    {
        Carro c1 = new Carro();
    }
}