using POO;

// Personagem tony = new Personagem();
// // exibindo as informações do objeto
// Console.WriteLine(tony.nome);
// Console.WriteLine(tony.idade);
// Console.WriteLine(tony.armadura);
// Console.WriteLine(tony.IA);

// // chamando os metodos da classe

// // so invocar pois ele so exibe (void)
// tony.Atacar();

// // chamei no cwl pois ele ele tem um retorno
// Console.WriteLine(tony.Defender);

// // so invocar pois ele so exibe (void)
// tony.RestaurarArmadura();

Personagem p1 = new Personagem();

Console.WriteLine($"Digite o nome:");
p1.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade:");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a armadura:");
p1.armadura = (Console.ReadLine());

Console.WriteLine($"Digite a ia se tiver:");
p1.IA = (Console.ReadLine());

Console.WriteLine(p1.IA);
Console.WriteLine($"{p1.armadura}");
Console.WriteLine($"{p1.idade}");
Console.WriteLine($"{p1.nome}");



