class tarefas
{

    static void Main()
    {
        var atividade1 = true; var atividade2 = false;

        var todas = atividade1 && atividade2;

        var umaApenas = atividade1 || atividade2;

        Console.WriteLine("Fez todas as atividades ? {0}", todas);
        Console.WriteLine("Fez pelo menos uma das atividades ? {0}", umaApenas);
        Console.WriteLine("Nao fez nenhuma? {0}", !umaApenas);
        
    }
}
