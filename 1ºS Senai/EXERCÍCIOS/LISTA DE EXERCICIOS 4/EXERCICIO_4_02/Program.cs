// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

float g = 5.30f;
float a = 4.90f;

Console.WriteLine($@"
@=========================@
|1-)Gasolina = R$5,30 o L,|
| até 20 litros ganha     |
| 4% de desconto,         |
| acima de 20 litos ganha |
| 6% de desconto          |
|-------------------------|
|2-)Álcool = R$4,90 o L,  |
| até 20 litros ganha     |
| 3% de desconto,         |
| acima de 20 litos ganha |
| 5% de desconto          |
@=========================@ 

Você deseja qual tipo de combustivel, álcool ou gasolina?
digite 1 para gasolina e 2 para álcool.");
float type = float.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"Quantos litros você deseja do combustivel?");
float qnt = float.Parse(Console.ReadLine());

float valor1 = (qnt * g);
float valor2 = (qnt * a);

if (type == 1)
{

    if (qnt <= 20)
    {
        Console.WriteLine($"O valor será de {Math.Round(valor1 - (0.04 * valor1))} reais");
    }
    else
    {
        Console.WriteLine($"O valor será de {Math.Round(valor1 - (0.06 * valor1))} reais");

    }
        Console.WriteLine($"foi comprado {qnt} litros de gasolina.");
    
}
else if (type == 2)
{
    if (qnt <= 20)
    {
        Console.WriteLine($"O valor será de {Math.Round(valor1 - (0.03 * valor1))}");
    }
    else
    {
        Console.WriteLine($"O valor será de {Math.Round(valor1 - (0.05 * valor1))}");

    }
        Console.WriteLine($"foi comprado {qnt} litros de gasolina.");
        
}


