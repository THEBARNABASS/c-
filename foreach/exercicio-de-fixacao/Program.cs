// ESCREVA UMA PROGAMA QUE RECEBA E IMPRIMA O NOME E IDADE DE 5 PESSOAS

// PERSONALIZAR CORES: A RESPOSTA DO NOME AZUL E A RESPOSTA DA IDADE VERDE

//EXEMPLO DE EXIBICAO

// ==============//
// NOME : CAUA   //
// IDADE : 19    //
// ==============//

// ==============//
// NOME : JONAS  //
// IDADE : 14    //
// ==============//

// ==============//
// NOME : MARIA  //
// IDADE : 41    //
// ==============//

// ==============//
// NOME : HOMER  //
// IDADE : 59    //
// ==============//

// ==============//
// NOME : TADEU  //
// IDADE : 39    //
// ==============//

// EXERCÍCIO:

// string[] nome = new string[5];
// int[] idade = new int [5];

// for (int nomes = 0; nomes < 5; nomes++)
// {
//         Console.WriteLine($"digite seu {nomes + 1}º nome:");
//         nome[nomes] = Console.ReadLine();
// }
//     for(int idades = 0; idades <5; idades++)
//     {
        
//         idade[idades] = int.Parse(Console.ReadLine());

//         Console.WriteLine($"digite a {idades + 1}º idade:");
//     }
// int p = 0
// foreach (var item in nome)
// {
    
//     foreach (var items in idade)
//     {
        
//         Console.ForegroundColor = ConsoleColor.Blue;
//         Console.WriteLine($"{p++})nome:"+item); 

//         Console.WriteLine($"");
        
//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.WriteLine($"  idade: {items} anos);
//         Console.ResetColor();
//     }
// }

// CORREÇÃO


// *****************************

 //Exercício de fixação
 
 //escreva um programa que receba e imprima o nome e idade de 5 pessoas

 //personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

//declarando as variáveis
string[] nomes = new string[5];//collection
int[] idades = new int[5];//collection

// recebe e armazena os nomes e idades nos arrays
for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"Informe a {i + 1}º idade: ");
    idades[i] = int.Parse(Console.ReadLine());         
}

// exibe o nome e a idade correspondente
for (var posicao = 0; posicao < 5; posicao++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{posicao + 1}) nome: {nomes[posicao]}  ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"  idade: {idades[posicao]} anos");
    Console.ResetColor();

    Console.WriteLine($"");    
}
	
