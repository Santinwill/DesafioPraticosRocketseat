namespace ExerciciosPraticos5;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe a placa do veículo: ");
        string placa = Console.ReadLine();

        ValidadorPlaca validadorPlaca = new ValidadorPlaca();
        bool isValid = validadorPlaca.ValidarPlaca(placa);

        Console.WriteLine(isValid ? "Verdadeiro" : "Falso");
    }
}