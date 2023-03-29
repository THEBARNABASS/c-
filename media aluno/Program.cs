Console.WriteLine($"Digite as 5 notas no seu aluno:");

Console.WriteLine($"Nota 1:");
float nota1= float.Parse(Console.ReadLine());

Console.WriteLine($"Nota 2:");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Nota 3:");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Nota 4:");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Nota 5:");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5)/5;

Console.WriteLine($"A media do aluno é : {media}");
