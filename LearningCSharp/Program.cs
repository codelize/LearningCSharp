using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu de escolha do programa
        Console.WriteLine("Escolha o programa a ser executado:");
        Console.WriteLine("1 - Finance Program");
        Console.WriteLine("2 - Hours Program");
        Console.WriteLine("3 - Miles Program");
        Console.WriteLine("4 - Triangle Calculation");

        string escolha = Console.ReadLine();

        // Chama o programa escolhido
        if (escolha == "1")
        {
            // Chama o Finance Program
            FinanceProgram.Executar();
        }
        else if (escolha == "2")
        {
            // Chama o Hours Program
            HoursProgram.Executar();
        }
        else if (escolha == "3")
        {
            // Chama o Miles Program
            MilesProgram.Executar();
        }
        else if (escolha == "4")
        {
            //Chama o Triangle Calculation
            TriangleCalculation.Executar();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}
