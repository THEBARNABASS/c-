Console.BackgroundColor = ConsoleColor.DarkYellow
Console.WriteLine(@$"
=======================
|    PROGAMA PARA     |
|   CALCULAR O IMC    |
=======================
");
Console.ResetColor()

Console.WriteLine($"Digite o nome do paciente:");
string nome = Console.ReadLine();

Console.WriteLine($"Bem Vindi ao nosso sistema {nome} XD");

Console.WriteLine($"Digite o peso do paciente:");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a altura do paciente:");
double altura = double.Parse(Console.ReadLine());

float imc = peso/((float)Math.Pow(altura,2));

Console.WriteLine($"O paciente {nome} tem imc igual á: {imc}");










