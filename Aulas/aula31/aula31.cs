using System;

class Player
{
    private string name;
    private int energy;

    public Player(string name)
    {
        this.name = name;
        this.energy = 100;
    }

    public string GetName()
    {
        return name;
    }

    public int GetEnergy()
    {
        return energy;
    }

    public void SetEnergy(int energy)
    {
        int res = this.energy + energy;

        if (res >= 0 && res <= 100)
        {
            this.energy = res;
        }
    }

    public void Setname(string name)
    {
        this.name = name;
    }
}

class Aula31
{
    public static void Main()
    {
        Player p1 = new Player("Ludmilla Oliveira");
        Player p2 = new Player("Jorge Oliveira");

        p1.SetEnergy(-80);
        p1.SetEnergy(-30);

        Console.WriteLine("Name: {0}\nEnergy: {1}", p1.GetName(), p1.GetEnergy());
        Console.WriteLine("Name: {0}\nEnergy: {1}", p2.GetName(), p2.GetEnergy());
    }
}
