using JogadoresDeFutebol;

Ataque ataque = new Ataque();
Defesa defesa = new Defesa ();
MeioCampo meioCampo = new MeioCampo();

Console.WriteLine($"Bem vindo ao menu para aposentadoria de Jogadores!");

defesa.CadastrarJogador();
// Muito interessante, o cadastro do jogador da defesa não é aplicado para o cadastro do Ataque ou do meio campo

defesa.CalcularIdade();
Console.WriteLine(defesa.Idade);

ataque.Idade = defesa.Idade;
meioCampo.Idade = defesa.Idade;

Console.WriteLine(ataque.Idade);
Console.WriteLine(meioCampo.Idade);


// Console.WriteLine($"Cadastro realizado.");
// Console.Write($"A idade do usuário é de: ");
// Console.WriteLine(defesa.CalcularIdade());

// ataque.CalcularIdade();
// meioCampo.CalcularIdade();

// Console.WriteLine(ataque.CalcularAposentadoria());
// Console.WriteLine(defesa.CalcularAposentadoria());
// Console.WriteLine(meioCampo.CalcularAposentadoria());