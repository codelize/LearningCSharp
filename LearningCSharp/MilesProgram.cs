

Console.Write("Digite a quantidade de milhas a serem convertidas: ");
string milhasInput = Console.ReadLine();

double milhas = double.TryParse(milhasInput, out double parsedMilhas) ? parsedMilhas : 0;

double quilometros = milhas * 1.60934;
Console.WriteLine($"O valor em quilometros é: {quilometros}");  