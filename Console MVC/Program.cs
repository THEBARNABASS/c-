using Console_MVC.Model;
using Console_MVC.Controller;

// INSTANCIA DO OBJ PRODUTO
Produto prdt = new Produto();

// INSTANCIA DO OBJ PRODUTOCONTROLLER
ProdutoController controller = new ProdutoController();

controller.CadastrarProduto();
// CHAMADA DO METODO CONTROLADOR
controller.ListarProdutos();
