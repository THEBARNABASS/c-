// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Simulação de descontos");

Console.WriteLine($"Informe o nome do produto:");
string nome = Console.ReadLine();

Console.WriteLine($"Informe a quantidade do produto:");
int qnt = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o preço unitário do produto:");
float value = float.Parse(Console.ReadLine());

float total = (qnt * value);

if(qnt <= 5)
{
    Console.WriteLine($"O valor será de {(total - (0.02 * total))} reais");
}
else if(qnt > 5 && qnt <= 10)
{
     Console.WriteLine($"O valor será de {Math.Round(total - (0.03 * total))} reais");
}
else
{
     Console.WriteLine($"O valor será de {(total - (0.05 * total))} reais");
}