using System;

class VeicleTon
{ 
    public static void Executar()
    {
        Console.Write("Quantas toneladas deseja transportar?");
        string pesoVeicle = Console.ReadLine();

        bool conversaoValida = double.TryParse(pesoVeicle, out double pesoTotal); 

        if (!conversaoValida || pesoTotal < 0)
        {
            Console.WriteLine("Valor inválido. Digite um número positivo.");
            return;
        }

        // Cada caminhão transporta 1 tonela
        // Descarta a parte decimal para contar apenas caminhões completos
        int quantidadeCaminhoes = (int)Math.Floor(pesoTotal);

        // Exibe o resultado
        Console.WriteLine($"Serão necessários {quantidadeCaminhoes} caminhão(ões) para transportar a carga.");
    }
}
    

    