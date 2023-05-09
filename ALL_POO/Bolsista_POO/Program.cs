// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using Bolsista_POO;

Aluno A = new Aluno();



Console.WriteLine($"Preencha seus dados:");

Console.WriteLine($"nome:");
A.nome = Console.ReadLine();

Console.WriteLine($"curso:");
A.curso = Console.ReadLine();


Console.WriteLine($"idade:");
A.idade = Console.ReadLine();


Console.WriteLine($"rg:");
A.rg = Console.ReadLine();


Console.WriteLine($"O aluno é bolsista? (s/n)");
string r = (Console.ReadLine().ToLower());

A.bolsista = r == "s" ? true : false;

Console.WriteLine($"media final:");
A.mediafinal = float.Parse(Console.ReadLine());

Console.WriteLine($"mensalidade:");
A.mensal = float.Parse(Console.ReadLine());

do
{
    
Console.WriteLine($@"
[1] ver media so aluno
[2] ver mensalidade do aluno

[0] sair");
string opc = Console.ReadLine();

switch (opc)
{
    case "1":
        Console.WriteLine($"a media do aluno {A.nome} é : {A.VerMediaFinal}");

        break;
    case "2":
        Console.WriteLine($"a mensalidade é {A.VerMensalidade()}");
        break;
    case "3":
        Console.WriteLine($"tchau!");
        break;
    default:
        Console.WriteLine($"opcao invalida");
        
        break;
}

} while (opc != "0");
