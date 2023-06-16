using System;
using System.Collections.Generic;

class Aula51
{
    static void Main(string[] args)
    {

        Dictionary<int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(0, "Carro");
        veiculos.Add(1, "Avião");
        veiculos.Add(2, "Moto");
        veiculos.Add(3, "Navio");
        veiculos.Add(4, "Patinet");

        Console.WriteLine("Tamanho do Dicionary: {0}", veiculos.Count);

        int key = 2;
        if (veiculos.ContainsKey(key))
        {
            Console.WriteLine("A chave {0} está na coleção", key);
        }
        else
        {
            Console.WriteLine("A chave {0} não está na coleção", key);
        }

        string value = "Navio";
        if (veiculos.ContainsValue(value))
        {
            Console.WriteLine("O valor {0} está na coleção", value);
        }
        else
        {
            Console.WriteLine("O valor {0} não está na coleção", value);
        }

        Console.WriteLine("----------------------------");
        foreach (KeyValuePair<int, string> v in veiculos)
        {
            Console.WriteLine("({0}, {1})", v.Key, v.Value);
        }
    }
}