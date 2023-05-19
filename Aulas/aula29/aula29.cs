using System;

public static class Player
{
    public static string name;
    public static int energy;
    public static bool alive;

    public static void Init(string n)
    {
        name = n;
        energy = 0;
        alive = true;
    }

    public static void Info()
    {
        Console.WriteLine("Player - Name: {0}, Energy: {1}, Alive: {2}", name, energy, alive);
    }
}

public class Enemy
{
    public static string name;
    public static int energy;
    public static bool alive;

    public static void Init(string n, int e)
    {
        name = n;
        energy = e;
        alive = true;
    }

    public static void Info()
    {
        Console.WriteLine("Enemy - Name: {0}, Energy: {1}, Alive: {2}", name, energy, alive);
    }

}

class Aula29
{
    static void Main()
    {
        Player.Init("Jorge Oliveira");
        Player.Info();

        Player.Init("Ludmilla Oliveira");
        Player.Info();

        Enemy.Init("MegaBoladao", 100);
        Enemy.Info();
    }
}