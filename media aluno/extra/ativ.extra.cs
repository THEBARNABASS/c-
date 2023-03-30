int anoNascimento;

int idade;

int IdadeEmSemanas;

int anoAtual = DateTime.Now.Year;

Console.WriteLine($"informe o ano do nascimento");
anoNascimento = int.Parse(Console.ReadLine());

idade = (anoAtual - anoNascimento);
IdadeEmSemanas = (idade * 52);

Console.WriteLine($"A idade em anos é (idade) anos e a idade em semanas é {IdadeEmSemanas} semanas");





