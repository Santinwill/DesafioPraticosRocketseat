namespace ExerciciosPraticos3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, digite o primeiro valor:");
        string valor1 = Console.ReadLine();
        Console.WriteLine("Por favor, digite o segundo valor:");
        string valor2 = Console.ReadLine();

        double value1 = double.Parse(valor1);
        double value2 = double.Parse(valor2);

        Operacoes operacoes = new Operacoes();
        Console.WriteLine($"Soma = {operacoes.Soma(value1, value2)}");
        Console.WriteLine($"Subtração = {operacoes.Subtracao(value1, value2)}");
        Console.WriteLine($"Multiplicação = {operacoes.Multiplicacao(value1, value2)}");
        Console.WriteLine($"Media = {operacoes.Media(value1, value2)}");

        if (value2 != 0)
            Console.WriteLine($"Divisão = {operacoes.Divisao(value1, value2)}");
        else
            Console.WriteLine("Não foi possivel realizar a divisão, o segundo valor deve ser diferente de ZERO.");

    }
}