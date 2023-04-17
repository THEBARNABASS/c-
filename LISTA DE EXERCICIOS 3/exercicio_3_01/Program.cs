// faça um progama que peça uma nota entre 0 & 10
// moostre uma mensagem caso o valor seja invalido 
// repita até o usuario informar um numero valido

Console.WriteLine($"Informe um número de 0 a 10:");
int nmr = int.Parse(Console.ReadLine());

while(nmr < 0 || nmr > 10)
{
    Console.WriteLine($"Este valor {nmr} é inválido, por favor informe um valor novo:");
    nmr = int.Parse(Console.ReadLine());
}
