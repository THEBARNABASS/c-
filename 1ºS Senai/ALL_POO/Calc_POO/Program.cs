// using Calc_POO;

// Calculadora op = new Calculadora();

// Console.WriteLine($"1º numero:");
// op.n1so = float.Parse(Console.ReadLine());

// Console.WriteLine($"2º numero:");
// op.n2so = float.Parse(Console.ReadLine());

// Console.WriteLine($"{op.Somar(op.n1so, op.n2so)}");

// ///////////////////////////////////////////////////////////////////////

// Console.WriteLine($"1º numero:");
// op.n1sb = float.Parse(Console.ReadLine());

// Console.WriteLine($"2º numero:");
// op.n2sb = float.Parse(Console.ReadLine());

// Console.WriteLine($"{op.Sub(op.n1sb, op.n2sb)}");

// ///////////////////////////////////////////////////////////////////////

// Console.WriteLine($"1º numero:");
// op.n1m = float.Parse(Console.ReadLine());

// Console.WriteLine($"2º numero:");
// op.n2m = float.Parse(Console.ReadLine());

// Console.WriteLine($"{op.Multi(op.n1m, op.n2m)}");

// ///////////////////////////////////////////////////////////////////////

// Console.WriteLine($"1º numero:");
// op.n1d = float.Parse(Console.ReadLine());

// Console.WriteLine($"2º numero:");
// op.n2d = float.Parse(Console.ReadLine());

// Console.WriteLine($"{op.Div(op.n1d, op.n2d)}");

//////////////////////CORREÇÃO////////////////////////////
using Calc_POO;

Calculadora op = new Calculadora();


Console.WriteLine($"***PROGAMA CALCULADORA***");
Console.WriteLine($"");

Console.WriteLine($"1º NÚMERO:");
op.n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"2º NÚMERO:");
op.n2 = float.Parse(Console.ReadLine());



Console.WriteLine($@"
ESCOLHA A OPERAÇÃO:

[1] SOMA
---------------
[2] SUBTRAÇÃO
---------------
[3] MULTIPLICAÇÃO
---------------
[4] DIVISÃO
---------------
[0] SAIR
");
String opc = Console.ReadLine();

switch (opc)
{
    case "1":
        Console.WriteLine(op.Somar());

        break;
    case "2":
        Console.WriteLine(op.Sub());

        break;
    case "3":
        Console.WriteLine(op.Multi());

        break;
    case "4":
        Console.WriteLine(op.Div());

        break;
    case "0":
        Console.WriteLine($"Bye!");

        break;
    default:
        Console.WriteLine($"opção inválida");

        break;
}

