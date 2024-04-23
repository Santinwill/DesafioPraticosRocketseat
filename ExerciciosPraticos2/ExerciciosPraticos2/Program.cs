namespace ExerciciosPraticos2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, digite seu nome:");

        string nome = Console.ReadLine();

        Console.WriteLine("Por favor, digite seu sobre nome:");

        string sobrenome = Console.ReadLine();

        Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
    }
}