// 0) ao finalizar a funcionalidade você repete o processo até o usuário finalizar - criar o loop
// 1) mostrar um texto na tela
// 2) escolher uma opção - solicitar a opção escolhida
// 3) chamar a funcionalidade

// *********** Criação das funcionalidades ou métodos *********** 
static bool CadastrarAlgo()
{
    Console.WriteLine($"Criar em Desenvolvimento");
    return true;
}

static void ListarAlgo()
{
    Console.WriteLine($"Listar em Desenvolvimento");
}



// *********** Início do programa *********** 
string opcao = "";

do
{
    Console.WriteLine(@$"
    Programa Menu Legal
Escolha uma opção no menu abaixo:

1) Cadastrar Algo
2) Listar Algo

0 - Sair
");

    opcao = Console.ReadLine();//lê a opção digitada pelo usuário

    switch (opcao)
    {
        case "1":
            bool cadastrado = CadastrarAlgo();
            break;
        
        case "2":
            ListarAlgo();
            break;
        
        case "0":
            Console.WriteLine($"Tchau, até breve!!");
            break;
        
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }
    



} while (opcao != "0");






