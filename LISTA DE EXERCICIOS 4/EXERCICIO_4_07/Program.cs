// Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

int[] nmr = new int[15];

Array.Reverse(nmr);

for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"digite seu {i+1}º número:");
    nmr[i] = int.Parse(Console.ReadLine());
    
}
Console.WriteLine($"");


 foreach (var item in nmr)
 {
    Console.WriteLine(item);

 }