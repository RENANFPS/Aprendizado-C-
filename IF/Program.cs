class Aprendizadoif
{
    static void Main()
    {

        var n1 = 5;
        var n2 = 9;
        var n3 = 10;

        if (n1 < n2)
        {
            Console.WriteLine("Condicao 1 e satisfeita!!:");
            Console.WriteLine("Resultado da soma e {0}", n1 + n2);

        }
        if (n3 < n2)
        {
            Console.WriteLine(n3 + n2);
        }
        else
        {
            Console.WriteLine("Condicao 2 nao e satisfeita!!");
        }
    }
}
