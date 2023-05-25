using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_MVC.Model
{
    public class Produto
    {
        //Propriedades
        //atalho: prop
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        //caminho da pasta e do arquivo definido.
        //csv só recebe texto
        private const string PATH = "Database/Produto.csv";

        //criar um construtor


        public Produto()
        {
        //Split: faz a separação da string (nesse caso com a / ) e devolve em array.
        //caminho da pasta do arquivo definido 
            string pasta = PATH.Split("/")[0];

        //se não existe uma pasta "Database", então cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
        //se não existe uma arquivo "Produto.csv", então cria-se um.
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

          public List<Produto> Ler()
          {
            //instanciar uma lista de produtos
            List<Produto> ListadeProdutos = new List<Produto>();

            //array que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            //para a leitura das linhas
            foreach (string item in linhas)
            {
                //antes do split 
                //001;coca;6,50

                //array que irá receber os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                //após split
                // atributos[0]= 001
                // atributos[1]= coca
                // atributos[2]= 6,50

                //intanciar objeto do produto
                Produto p = new Produto();

                //atribuir os dados de um objeto
                p.Codigo = int.Parse(atributos [0]);//001
                p.Nome = (atributos [1]);//Coca
                p.Preco = float.Parse(atributos [2]);//6,50

                //adicionar o objeto dentro da lista
                ListadeProdutos.Add(p);

            }

                //retorna a lista de produtos
                return ListadeProdutos;
            }
            //Método para preparar linhas do CSV.
          public string PrepararLinhasCSV(Produto p)
          {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
          }

          //Método para inserir um produto  no arquivo csv.
          public void InserirProduto(Produto p)
          {
            //adiciona o método prepararlinhas com o produto dentro de um array "Linhas".
            string[] linhas= {(PrepararLinhasCSV(p))};

            File.AppendAllLines(PATH,linhas);
          }


 


    }
}