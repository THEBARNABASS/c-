using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_mercadoria.classes
{
    public class Marca
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


        public static List<Marca> marca = new List<Marca>();
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }



        public Marca Cadastrar()
        {

            Marca novamarca = new Marca();

            Console.WriteLine($"CÓDIGO DA MARCA:");
            int _codigo = int.Parse(Console.ReadLine());

            novamarca = (marca.Find(x => x.Codigo == _codigo) != null );

            if (novamarca == null)
            {
                novamarca = new Marca();

                System.Console.WriteLine($"NOME DA MARCA:");
                novamarca.NomeMarca = Console.ReadLine();
                novamarca.DataCadastro = DateTime.UtcNow;
                marca.Add(novamarca);
                return novamarca;
            }
            else
            {
                System.Console.WriteLine("Marca já cadastrada!");
                return novamarca;
            }
        }
        public void Listar()
        {
            if (marca.Count > 0 || marca != null)
            {
                foreach (Marca item in marca)
                {
                    Console.WriteLine($@"
                    CÓDIGO DA MARCA: {item.Codigo}
                    NOME DA MARCA: {item.NomeMarca}
                     ");
                }
            }
            else
            {
                Console.WriteLine($" Sem marcas registradas!");
            }

        }
        public void indice(int _indx)
        {
            int mcode = PerguntaInt("CÓDIGO DA MARCA:");

            int index = marca.IndexOf(marca.Find(x => x.Codigo == _indx));



        }
        public void Deletar(int _codigo)
        {
            int index = marca.IndexOf(marca.Find(x => x.Codigo == _codigo));

            string r = PerguntaString("Deseja excluir o produto? (S/N)").ToLower();
            if (r == "s")
            {
                marca.RemoveAt(index);
                ExibeMensagem("marca excluída!");
            }
            if (r == "n")
            {
                ExibeMensagem("marca não excluída!");
            }
            else
            {
                ExibeMensagem("Resposta inválida!");
            }

        }



    }
}
//    void buscar(int _codigo, Produto _novoProduto)
//                     {
//                        p.Find(x => x.Codigo == _codigo).NomeM;

//                     }