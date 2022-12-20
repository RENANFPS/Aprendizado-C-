class Conclusao
{
    static void Main()
    {
        float media = 0;

        Console.WriteLine("Ola, Bem vindo ao programa de calculo de media!");

        Console.WriteLine("Irei auxiliar voce a calcular a media do seu aluno!");

        Console.WriteLine("Digite a Primeira nota: ");
        int.TryParse(Console.ReadLine(), out int nota1);

        Console.WriteLine("Digite a segunda nota: ");
        int.TryParse(Console.ReadLine(), out int nota2);

        Console.WriteLine("Digite a Terceira nota: ");
        int.TryParse(Console.ReadLine(), out int nota3);

        media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("A media do aluno e: {0}", media);

        if(media < 7)
        {
            Console.WriteLine("Aluno esta em recuperacao!");
        }
        else
        {
            Console.WriteLine("Aluno aprovado!!!");
        }
    }
}
