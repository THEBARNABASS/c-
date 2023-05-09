// nome != vazio

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

//=================nome==================
Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Invalido digite novamente por favor:");
    nome = Console.ReadLine(); 
}

//=============idade======================
Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

while (idade != 0 && idade > 100 )
{
    Console.WriteLine($"Digite novamente:");
    idade = int.Parse(Console.ReadLine());
}

//=================salario=======================
Console.WriteLine($"Digite o valor do seu salario:");
float salario = float.Parse(Console.ReadLine());

while (salario == 0 )
{
    Console.WriteLine($"Digite novamente:");
    salario = float.Parse(Console.ReadLine());
    
}

Console.WriteLine($"Digite seu estado civil, sendo C para casado, V para viuvo e D para divorciado:");
string civil = Console.ReadLine();

while (civil != "c" && civil != "v" && civil != "d" )
{
     Console.WriteLine($"Digite novamente:");
    civil = Console.ReadLine();
}













