namespace ExerciciosPraticos6;

class Program
{
    static void Main()
    {
        DateTime agora = DateTime.Now;

        Console.WriteLine("Escolha o formato de data desejado:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        string escolha = Console.ReadLine();

        string resultado = escolha switch
        {
            "1" => agora.ToString("dddd, dd MMMM yyyy HH:mm:ss"),
            "2" => agora.ToString("dd/MM/yyyy"),
            "3" => agora.ToString("HH"),
            "4" => agora.ToString("dd MMMM yyyy"),
            _ => "Opção inválida."
        };
        Console.WriteLine(resultado);
    }
}