using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_de_mercadoria.classes;

namespace Projeto_de_mercadoria.classes
{
    public class Produto
    {
        static string PerguntaString(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }

        static char PerguntaChar(string pergunta)
        {
            Console.WriteLine(pergunta);
            return char.Parse(Console.ReadLine());
        }

        static int PerguntaInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }

        static float PerguntaFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            return float.Parse(Console.ReadLine());
        }

        static void ExibeMensagemPulandoLinha(string texto)
        {
            Console.WriteLine(texto);
        }

        static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Usuario user = new Usuario();
        public int codigop { get; private set; }
        public string NomeProduto { get; private set; }
        public float preco { get; private set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Cadastropor { get; set; }
        public Marca Marca = new Marca();
        public List<Produto> p = new List<Produto>();


        public void Cadastrar()
        {

            Produto novoproduto = new Produto();

            novoproduto.codigop = PerguntaInt("CÓDIGO DO PRODUTO:");

            novoproduto.NomeProduto = PerguntaString("NOME DO PRODUTO:");

            novoproduto.preco = PerguntaFloat("PREÇO DO PRODUTO:");

            ExibeMensagem("DATA : " + DateTime.UtcNow);

            Console.WriteLine($"");

            novoproduto.Marca = Marca.Cadastrar();

            Console.Write($"CADASTRADO POR: {user.Nome}");
            novoproduto.Cadastropor = new Usuario();

            p.Add(novoproduto);
        }

        public void Listar()
        {
            if (p.Count > 0 || p != null)
            {
                foreach (Produto item in p)
                {
                    Console.WriteLine(@$"
                    Código: {item.codigop}
                    Nome: {item.NomeProduto}
                    Preço: R${item.preco:C}
                    Marca: {item.Marca.NomeMarca}
          
                    ");

                }
            }
            else
            {
                Console.WriteLine($" Sem  Produtos!");
            }
        }


        public void Deletar(int _codigop)
        {
            int index = p.IndexOf(p.Find(x => x.codigop == _codigop));

            string r = PerguntaString("Deseja excluir o produto? (S/N)").ToLower();
            if (r == "s")
            {
                p.RemoveAt(index);
                ExibeMensagem("Produto excluído!");
            }
            if (r == "n")
            {
                ExibeMensagem("Produto não excluído1");
            }
            else
            {
                ExibeMensagem("Resposta inválida!");
            }

        }





    }
}


