// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)
using System.Globalization;
using conversor.classe;

string opc;
do
{
    

Console.WriteLine($@"
@======================@
|  conversão de moeda  |
|======================|
|[1] - Real para dolar |
|----------------------|
|[2] - Dolar para real |
|----------------------|
|[0] - Sair            |
@======================@

");
 opc = Console.ReadLine();

switch (opc)
{
    case "1":
        Console.WriteLine($"Valor de reais:");
        int n1r = int.Parse(Console.ReadLine());
        Console.WriteLine($"Cotação :");
        int n2r = int.Parse(Console.ReadLine());

        Console.WriteLine($"{Dollar.rpd(n1r, n2r).ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}");
        break;
    case "2":
        Console.WriteLine($"Valor de dolares :");
        int n1d = int.Parse(Console.ReadLine());
        Console.WriteLine($"Cotação:");
        int n2d = int.Parse(Console.ReadLine());

        Console.WriteLine($"{Dollar.dpr(n1d, n2d).ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}");
        break;
    case "0":
        Console.WriteLine($"bye");

        break;
    default:
        Console.WriteLine($"Opção inválida");
        break;
}

} while (opc != "0");


