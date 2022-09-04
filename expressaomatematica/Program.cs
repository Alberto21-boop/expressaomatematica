namespace expressaomatematica;

public class Program
{
    static void Main(string[] args)
    {
        //1) Resolva a expressão numérica: 30 ÷ [10 + (2 + 3)]

        Console.WriteLine("vamos resolver a expressão numérica: 30 ÷ [10 + (2 + 3)]");

        int resposta;

        resposta = 30 / (10 + (2 + 3));

        Console.WriteLine("O resultado é = " + resposta);
    }
}