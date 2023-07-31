// Criar uma lista de obj(produtos)
using listas_objetos.list;

// CREATE

List<Produto> produtos = new List<Produto>();

// Inserir obj de produtos dentro da lista

produtos.Add(
    new Produto(1234,"camisa", 19.99f)
);

// através de uma instancia basica de obj

Produto camisetaArmani = new(1235,"camisaArmani", 49.90f);
produtos.Add(camisetaArmani);

// READ

Console.WriteLine($"produtos antes de alterar");

foreach(var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, nome: {item.Nome}, preço: {item.Preco:C}");
    
}

// UPDATE

// ACESSAR O OBJ DA LIST PARA PODER MANIPULALO

Produto produtofind = produtos.Find(X => X.Codigo == 1235);

// ENCONTRAR O INDICE ENCONTRADO

int index = produtos.IndexOf(produtofind);

// EXIBIR O INDICE NO CONSOLE--------------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine($"o indice encontrado é : {index}");

// FAZER ALTERAÇÕES

produtofind.Preco = 599f;

// REMOVER O ITEM ANTIGO DA LISTA

produtos.RemoveAt(index);

// DEVOLVER ITEM ATUALIZADO

produtos.Insert(index,produtofind);

Console.WriteLine($"produtos depois de alterar");


foreach(var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, nome: {item.Nome}, preço: {item.Preco:C}");
    
}

// DELETE

