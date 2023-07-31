// - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido

int[] nmr = new int[10];

int menor = 0,maior = 0;
Console.WriteLine($"Informe 10 numeros:");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Informe o {i+1}º número: ");    
    nmr[i] = int.Parse(Console.ReadLine());       
}

for (int i = 0; i < 10; i++)
{
    if(nmr[i] < menor )
    {
        menor = nmr[i];
    }
    else if(nmr[i] > maior)
    {
        maior = nmr[i];
    }
}

Console.WriteLine($"O menor número é {menor}");
Console.WriteLine($"O maior número é {maior}");

