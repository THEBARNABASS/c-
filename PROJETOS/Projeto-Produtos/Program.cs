﻿// Os produtos terão os seguintes atributos:

// .string Nome
// .float Preco
// .bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:

// .CadastrarProduto
// .ListarProdutos
// .MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

int count = 3;
char opcao;
string[] produtos = new string[count];
float[] preco = new float[count];
bool[] promocao = new bool[count];
string resposta;

static bool validarPromo()
{
    Console.WriteLine($"o produto está em promoção?");
    string resposta = Console.ReadLine();
    
    if (resposta == "sim")
    {
        return true;
    }
    else{
        return false;
    }
}

static void cadastro(string[] nome,float[] preco, bool[] promocao)
{
    for (int i = 0; i < nome.Length; i++)
    {
     Console.WriteLine($"Produto:");
     nome[i]= Console.ReadLine();

     Console.WriteLine($"Preço:");
     preco[i]= float.Parse (Console.ReadLine());    

     promocao[i]= validarPromo();     
    }  
}
do
{
    Console.WriteLine(@$"
Escolha uma opção do menu:
1-cadrastrar produto
2-Listar produto
3-mostrar menu
");

    opcao = char.Parse(Console.ReadLine());
    switch (opcao)
    {
        case '1':
            cadastro(produtos,preco,promocao);
            break;
        case '2':
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"------------------------");
                
                Console.WriteLine($"Produto:{produtos[i]}");
                Console.WriteLine($"preço:{preco[i]}");
                if (promocao[i] == true)
                {
                    Console.WriteLine($"**o produto está em promoção**");
                }
                else
                {
                    Console.WriteLine($"");
                    
                }        
            }
            break;
        default:
            break;
    }

} while (opcao != 3);
