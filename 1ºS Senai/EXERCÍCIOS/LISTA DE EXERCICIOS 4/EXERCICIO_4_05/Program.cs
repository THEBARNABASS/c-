// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

for (var i = 0; i <= 10; i++)
{
for (var z = 0; z <= 10; z++)
{
    Console.WriteLine($@"|*| {i} X {z} = {i * z}     ");
    
}
    Console.WriteLine($"");
}