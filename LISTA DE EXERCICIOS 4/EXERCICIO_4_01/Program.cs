// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Digite o ano de seu nascimento:");
int ano = int.Parse(Console.ReadLine());

if(ano > 2007)
{
    Console.WriteLine($"Pessoas nascidas depois de 2007, Não podem votar pois não tem idade suficiente.");
    
}
else
{
    Console.WriteLine($"Este ano você poderá votar.");
    
}