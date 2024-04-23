using System.Numerics;
using System.Text.RegularExpressions;

namespace ExerciciosPraticos5;
public class ValidadorPlaca
{
    public bool ValidarPlaca(string placa)
    {
        if (placa == null) 
            return false;

        string placaLimpa = Regex.Replace(placa, "[^a-zA-Z0-9]", "");

        Regex regex = new Regex("^[A-Za-z]{3}[0-9]{4}$");

        return regex.IsMatch(placaLimpa);
    }
}