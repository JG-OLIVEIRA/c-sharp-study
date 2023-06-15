using System;

namespace Calc1
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}

namespace Calc2
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas * alt;
        }
    }
}

class Aula48
{
    public static void Main(string[] args)
    {
        float area = 0;

        try
        {
            area = Calc1.Quad(0, 5F);
            Console.WriteLine("Area do quadrado.: {0}", area);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }

    }
}
