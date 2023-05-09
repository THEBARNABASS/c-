// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"dia:");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"mês:");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"ano:");
int ano = int.Parse(Console.ReadLine());

if (dia <= 31 && mes <= 12 && ano <= 2013)
{
    Console.WriteLine($"Esta data é valida");
    
}
else if (dia > 31)
{
    Console.WriteLine($"Esta data não é valida, o mes contem apenas 31 dias.");
    
}
else if(mes > 12)
{
    Console.WriteLine($"Esta data não é valida, o ano contem apenas 12 meses.");
}
else if (ano > 2013)
{
    Console.WriteLine($"Esta data não é valida, o ano atual é 2013.");
}