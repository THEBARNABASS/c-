// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

// string[] nome = new string[10];

// bool encontrado = false;

// for (var i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Digite seu {i+1}º nome:");  
//     nome[i] = Console.ReadLine();
    
    
// }

// Console.WriteLine($"Search:");
// String find = Console.ReadLine();

// foreach(string item in nome)
// {
//     if(nome == find)
//     {
//         encontrado = true;
//         break;
//     }
// }

// CORREÇAO

// if (encontrado == true)
// {
//     Console.WriteLine($"ACHEIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!");    
// }
// else
// {
//     Console.WriteLine($"NÃO  ACHEIIIIIIIIIIIIIIIIIIIIIIIII!");    
// }

string[] nomes = new string[10];

bool encontrado = false;

for (var i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine();    
}

Console.WriteLine($"Informe um nome a ser buscado: ");
string nomeBuscado = Console.ReadLine();

//processamento
foreach (string nome in nomes)
{
   if (nome == nomeBuscado)
   {
        encontrado = true;
        break;
   } 
}
//saída

string resultadoPesquisa = encontrado == true ? "ACHEI" : "NÃO ACHEI";
Console.WriteLine(resultadoPesquisa);


// if (encontrado == true)
// {
//     Console.WriteLine($"Achei");
// }
// else
// {
//     Console.WriteLine($"Não achei");
// }

// string resposta = encontrado == true ? "Achei" : "Nao achei";
// Console.WriteLine(resposta);

Console.WriteLine(encontrado == true ? "Achei" : "Nao achei");

