using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        //método para exibir os dados da lista de produtos
        public void Listar(List<Produto> Produto)
        {
            Console.Clear();
            //foreach  para ler a lista passada como Paramêtro
            foreach (var item in Produto)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}\n"); 
            }
        }

        public Produto Cadastrar()
        {
            Produto ObjProduto = new Produto();
            
            Console.WriteLine($"Informe o codigo:");
            ObjProduto.Codigo= int.Parse (Console.ReadLine());

            Console.WriteLine($"Informe o Nome:");
            ObjProduto.Nome= Console.ReadLine();

            Console.WriteLine($"Informe o Preço:");
            ObjProduto.Preco= float.Parse (Console.ReadLine());

            return ObjProduto;
            
        }
    }
}