using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public void info()
    {
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor: {0}", this.cor);
        Console.WriteLine("------------------------");
    }
}


class Aula40
{
    static void Main()
    {
        Carro[] carros = new Carro[4];

        carros[0].modelo = "HRV";
        carros[0].cor = "Prata";

        carros[1].modelo = "Golf";
        carros[1].cor = "Azul";

        carros[3].modelo = "Jetta";
        carros[3].cor = "Branco";

        carros[3].modelo = "Argo";
        carros[3].cor = "Preto";

        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].info();
        }
    }
}