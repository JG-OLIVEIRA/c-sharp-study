using System;

class Aula25{
    static void Main(){
        int a, b, q, r;
        a=10;
        b=2;
        q = Divide(a, b, out r);
        Console.WriteLine("{0}/{1}: quociente={2} e resto={3}", a, b, q, r);
    }

    static int Divide(int dividendo, int divisor, out int resto){
        resto=dividendo%divisor;
        return dividendo/divisor;
    }

}