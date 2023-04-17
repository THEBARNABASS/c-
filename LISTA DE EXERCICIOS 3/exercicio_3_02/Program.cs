//faça um progama que leia usuario e senha
//não deixe a senha ser igual ao usuario
//caso aconteça, mostre uma mensagem e peça novamente as informações

Console.WriteLine($"Usuario:");
string user = Console.ReadLine();

Console.WriteLine($"Senha:");
string senha = Console.ReadLine();

while(user == senha)
{
    Console.WriteLine($"A senha não pode ser igual o usuário, por favor digite novamente:");  
    senha = Console.ReadLine();
    
}