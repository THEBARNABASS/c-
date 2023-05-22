using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_mercadoria.classes
{
    public class Login
    {
        public bool Logado { get; set; }


        public Login()
        {
            Usuario user = new Usuario();

            logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void logar(Usuario usuario)
        {
            do
            {


                Console.WriteLine($"Usúario:");
                string Email = Console.ReadLine().ToLower();

                Console.WriteLine($"Senha:");
                string senha = Console.ReadLine().ToLower();

                if (Email == usuario.Email && senha == usuario.Senha)
                {
                    this.Logado = true;
                    Console.WriteLine($"LOGIN EFETUADO COM SUCESSO!");

                }
                else
                {
                    this.Logado = false;
                    Console.WriteLine($"USUARIO OU SENHA INVÁLIDOS!");

                }
            } while (Logado == false);
        }
        public void Deslogar()
        {
            Logado = false;
        }
        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            @========================@
            |[1] - Cadastrar Produto |
            |[2] - Listar Produtos   |
            |[3] - Remover Produto   |
            |------------------------|
            |[4] - Cadastrar Marca   |
            |[5] - Listar Marcas     |
            |[6] - Remover Marca     |
            |------------------------|
            |[0] - Sair              |
            @========================@
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //cadastrar
                        produto.Cadastrar();
                        break;
                    case "2":
                        //listar
                        produto.Listar();
                        break;
                    case "3":
                        //remover
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        //cadastrar
                        marca.Cadastrar();
                        break;
                    case "5":
                        //listar
                        marca.Listar();
                        break;
                    case "6":
                        //remover
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        //sair
                        Console.WriteLine($"App encerrado !");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } while (opcao != "0");

        }

    }
}