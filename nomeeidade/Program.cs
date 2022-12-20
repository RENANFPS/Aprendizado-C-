class nomeIdade
{
    static void Main()
    {
        Console.WriteLine("Qual seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos anos?");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Estado civil?");
        string estadoCivil = Console.ReadLine();

        Console.WriteLine("Seu nome e {0} e sua idade e {1}. Seu estado civil e {2}", nome, idade,estadoCivil);
    }
}