using System;

class MilesProgram
{
    public static void Executar()
    {
        // Solicita a quantidade de milhas
        Console.Write("Digite a quantidade de milhas a serem convertidas: ");
        string milhasInput = Console.ReadLine();

        double milhas = double.TryParse(milhasInput, out double parsedMilhas) ? parsedMilhas : 0;

        // Converte milhas para quilômetros
        double quilometros = milhas * 1.60934;
        Console.WriteLine($"O valor em quilômetros é: {quilometros}");
    }
}
