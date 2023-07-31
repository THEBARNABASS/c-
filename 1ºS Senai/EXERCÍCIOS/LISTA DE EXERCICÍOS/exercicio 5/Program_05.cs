// 5)As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"numero de maçãs a serem compradas:");
int maca = int.Parse(Console.ReadLine()); 

float valor = 0.30f;

float valor2 = 0.25f;



if( maca <= 12)
{
 float valorfinal = maca * valor;
 Console.WriteLine("valor da compra:" + valorfinal);
 
}
else if (maca > 12)
{
    float valorfinal = maca * valor2;
    Console.WriteLine("valor da compra:" + valorfinal);  
}
else{

    Console.WriteLine($"numero não válido");
    
}