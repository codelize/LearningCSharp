using System;

class NewReword
{
    public static void Executar()
    {
        decimal salarioAtual = 4500.0m;
        decimal percentualAumento = 5.37m;
        decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100);

        Console.WriteLine($"O novo salário é de R$" + novoSalario.ToString("F2"));
    }
}

