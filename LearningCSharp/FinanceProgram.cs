using System;

class FinanceProgram
{
    public static void Executar()
    {
        // 1. Captura idade
        Console.Write("Digite sua idade: ");
        string idadeInput = Console.ReadLine();
        int idade = int.TryParse(idadeInput, out int parsedIdade) ? parsedIdade : 0;

        // 2. Captura valor do depósito
        Console.Write("Digite o valor que deseja depositar: ");
        string input = Console.ReadLine();

        if (!decimal.TryParse(input, out decimal depositAmount) || depositAmount <= 0)
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            return;
        }

        // 3. Verifica se o depósito será anônimo
        Console.Write("Deseja que o depósito seja anônimo? (s/n): ");
        string anonimatoInput = Console.ReadLine()?.ToLower();
        bool isAnonymous = anonimatoInput == "s";

        // 4. Tipo de conta
        Console.Write("Digite o tipo da conta (P para poupança, C para corrente): ");
        string contaInput = Console.ReadLine()?.ToUpper();
        char tipoConta = (contaInput == "P" || contaInput == "C") ? contaInput[0] : ' ';

        if (tipoConta != 'P' && tipoConta != 'C')
        {
            Console.WriteLine("Tipo de conta inválido. Use apenas 'P' ou 'C'.");
            return;
        }

        // 5. Exibe resumo
        Console.WriteLine("\n--- Resumo da Operação ---");
        Console.WriteLine($"Idade do usuário: {idade} anos");
        Console.WriteLine($"Valor do depósito: {depositAmount:C}");
        Console.WriteLine($"Depósito anônimo: {(isAnonymous ? "Sim" : "Não")}");
        Console.WriteLine($"Tipo de conta: {(tipoConta == 'P' ? "Poupança" : "Corrente")}");
    }
}
