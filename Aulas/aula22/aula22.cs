using System;

class Aula22
{
    static void Main()
    {
        int[] vector1=new int[5];
        int[] vector2=new int[5];
        int[] vector3=new int[5]; 

        Random random = new Random();

        for(int i=0;i<vector1.Length;i++)
        {
            vector1[i] = random.Next(50);
        }

        Console.Clear();
        Console.Write("Elementos do vetor: ");
        foreach(int n in vector1)
        {
            Console.Write("[{0}]", n);
        }
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Binary Search");
        int key=33;
        int pos=Array.BinarySearch(vector1, key);
        Console.WriteLine("Valor {0} está na posição {1}", key, pos);

        Console.WriteLine("---------------------------------------");

        Console.Write("Copy");
        Array.Copy(vector1, vector2, vector1.Length);
        foreach(int n in vector2)
        {
            Console.Write("[{0}]", n);
        }

        Console.WriteLine("---------------------------------------");

        Console.Write("CopyTo");
        vector1.CopyTo(vector3, 0);
        foreach(int n in vector2)
        {
            Console.Write("[{0}]", n);
        }
        
    }
    
}