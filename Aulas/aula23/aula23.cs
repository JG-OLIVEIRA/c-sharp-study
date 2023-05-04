using System;

class Aula23{
    static void Main(){
        int a, b;
        a=10;
        b=20;
        HelloWord(); 
        Console.WriteLine("A soma de {0} com {1} é igual a: {2}", a, b , Sum(a, b));
    }
    
    static void HelloWord(){
        Console.WriteLine("Hello Word!!!");
    }

    static int Sum(int a, int b){
        return a+b;
    }
}