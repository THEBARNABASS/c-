using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Crie uma classe chamada "produto" 
// Crie as prop : código, Nome, Preço
// Crie um construtor vazio desta classe
// Crie um construtor  com todo os atributos

namespace listas_objetos.list
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto()
        {

        }
        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}