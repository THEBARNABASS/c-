// Criar um progama em c# que receba 5 nmrs int e ao final exiba o dobro

// voce deve ultilizar a estrutura array com tamanho 5 
// para o armazenamento dos numeros, a estrutura foreach para exibilos

// entrada
    // criar array tamanho 5
// processamento 
    // receber os 5 numeros
// saida
    // exibir os numeros com (foreach)

int[] nmr = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o número: ");    
    nmr[i] = int.Parse(Console.ReadLine());    
}

Console.WriteLine($"numeros escolhidos:");

foreach(var item in (nmr))
{
    Console.WriteLine(item * 2);
    Console.WriteLine($"----");
    
}





// CORREÇÃO

// Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

// Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibí-los

// entrada
    // criar o array tamanho 5
    // int[] arrayNumeros = new int[5];
// processamento
    // recebeber os números (for)
    // for (int indice = 0; indice < 5; indice++)
    // {

        // Console.WriteLine($"Digite o {indice + 1}º número");
        // arrayNumeros[indice] = int.Parse(Console.ReadLine());
        
        
    // }
 
// saída  
    // exibir os números com (foreach) 
    // foreach (var numero in arrayNumeros)
    // {
        // Console.WriteLine($"O dobro de {numero} é {numero * 2}");
        
    // }
