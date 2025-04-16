using System;

class HoursProgram
{
    public static void Executar()
    {
        // Solicita a quantidade de minutos
        Console.Write("Digite a quantidade de minutos: ");
        string minutosInput = Console.ReadLine();

        int minutosTotais = int.TryParse(minutosInput, out int parsedMinutos) ? parsedMinutos : 0;

        // Calcula as horas e minutos restantes
        int horas = minutosTotais / 60;
        int minutosRestantes = minutosTotais % 60;

        // Exibe os resultados
        Console.WriteLine($"Horas completas: {horas}");
        Console.WriteLine($"Minutos restantes: {minutosRestantes}");
    }
}
