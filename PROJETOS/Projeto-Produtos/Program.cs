// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

string opcao = "";
bool promocao = false;
string[] produtos = new string[10];

static bool Cadastrar()
{
    Console.WriteLine($"Nome do Produto:");
    string nome = Console.ReadLine();

    Console.WriteLine($"Preço:");
    float preco = float.Parse(Console.ReadLine());
    return true;

}


do
{
    Console.WriteLine($@"
            @MENU@
    
    [1] - Cadastrar
    [2] - Lidar
    [0] - sair

    ");

    opcao = Console.ReadLine();//lê a opção digitada pelo usuário

    switch (opcao)
    {

        case "1":

            string r = "";

            do
            {
                for (var i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"Produto{i+1}º:");
                    produtos[i] = Cadastrar();
                }

                Console.WriteLine($"Gostaria de cadastrar um novo produto? (S/N)");
                r = Console.ReadLine().ToLower();
            } while (r == "s");

            break;

        case "2":

            break;

        case "0":
            Console.WriteLine($"Fim");
            break;

        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }




} while (opcao != "0");



