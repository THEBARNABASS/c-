Console.WriteLine($"Informe um numero inteiro:");
int nmr = int.Parse(Console.ReadLine());

for(int tab = 0; tab <11 ; tab++)
{
    Console.WriteLine($"{nmr} x {tab} =" + nmr * tab);
}


