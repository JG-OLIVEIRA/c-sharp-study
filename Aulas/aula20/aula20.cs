using System;

class Aula20
{
    static void Main()
    {
        string password="passwordaula20";
        string checkPassword = "";
        int attempts = 0;

        do
        {
            Console.Clear();
            Console.Write("Digite a senha: ");
            checkPassword = Console.ReadLine();
            attempts++;
        }while(password!=checkPassword);

        Console.WriteLine("Senha correta! Número de tentativas: {0}", attempts);
    }
}