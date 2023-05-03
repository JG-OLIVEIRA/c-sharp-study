using System;

class Aula21{
    static void Main(){

        int[] num=new int[3]{11, 22, 33};


        /*
        for(int i=0;i<num.Length;i++){
            Console.WriteLine(num[i]);
        } // loop for que já conhecemos
        */

        foreach(int n in num){
            Console.WriteLine(n);
        }

    }
}