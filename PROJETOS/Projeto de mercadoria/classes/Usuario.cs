using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_mercadoria.classes
{
    public class Usuario
    {
        public int codigou { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; set; }

        List<Usuario> usuario = new List<Usuario>();

        public Usuario()
        {
            Cadastrar();
        }
        public void Cadastrar()
        {
            // Console.WriteLine($"Preencha os campos para efetuar o cadastro");
            // Console.WriteLine($"CÓDIGO:");
            // this.codigou = int.Parse(Console.ReadLine());
            // Console.WriteLine($"NOME:");
            // this.Nome = Console.ReadLine();
            // Console.WriteLine($"E-MAIL:");
            // this.Email = Console.ReadLine();
            // Console.WriteLine($"SENHA:");
            // this.Senha = Console.ReadLine();
            codigou = 30;
            Nome = "Cauã";
            Email = "1";
            Senha = "1";
            this.DataCadastro = DateTime.Now;
        }
        public void Deletar()
        {
            // Console.WriteLine($"digite o código do usuario que deseja remover:");
            // int remove = int.Parse(Console.ReadLine());

            // usuario.RemoveAt(remove);
            // this.Nome = "";
            // this.Email = "";
            // this.Senha = "";
            // this.DataCadastro = DateTime.Parse("0000-00-00-00-00");
        }


    }
}