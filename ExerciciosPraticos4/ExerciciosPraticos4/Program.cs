namespace ExerciciosPraticos4;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        string input = Console.ReadLine();
        int contador = 0;
        foreach (char caractere in input)
            if (caractere != ' ') 
                contador++;
        Console.WriteLine($"A quantidade de caracteres (sem contar espaços) é: {contador}");
    }
}