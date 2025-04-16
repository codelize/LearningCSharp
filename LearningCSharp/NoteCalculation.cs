using System;

class NotaCalculation
{
    public static void Executar()
    {
        float nota1 = 7.2f;
        float nota2 = 8.3f;
        float nota3 = 9.1f;

        float media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"A média das 3 notas é: {media} .");
    }
}
