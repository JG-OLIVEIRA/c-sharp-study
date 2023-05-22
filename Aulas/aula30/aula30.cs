using System;

public static class Player
{
    public static string name;
    public static int energy;
    public static bool alive;

    public static void Init(string name)
    {
        this.name = name;
        this.energy = 0;
        this.alive = true;
    }

    public static void Info()
    {
        Console.WriteLine("Player - Name: {name}, Energy: {energy}, Alive: {alive}");
    }
}

public class Enemy
{
    public static string name;
    public static int energy;
    public static bool alive;

    public static void Init(string name, int energy)
    {
        this.name = name;
        this.energy = energy;
        this.alive = true;
    }

    public static void Info()
    {
        Console.WriteLine("Enemy - Name: {name}, Energy: {energy}, Alive: {alive}");
    }

}

class Aula30
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