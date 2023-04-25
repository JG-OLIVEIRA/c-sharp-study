using System;

class aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}

    static void Main(){
        DiasSemana ds = (DiasSemana) 3;
        Console.WriteLine(ds);
    }
}