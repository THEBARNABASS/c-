// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Digite o primeiro numero:");
int n1 = int.Parse(Console.ReadLine());


Console.WriteLine($"Digite o segundo numero:");
int n2 = int.Parse(Console.ReadLine());


Console.WriteLine($"Digite o terceiro numero:");
int n3 = int.Parse(Console.ReadLine());

if(n1 > n2 || n1 > n3)
{
    Console.WriteLine($"o primeiro numero é maior {n1}");
    

    if (n2 > n1 || n2 >n3)
    {
         Console.WriteLine($"o segundo numero é maior {n2}");

        if (n3 > n1 || n3 > n2)
       
             Console.WriteLine($"o primeiro numero é maior {n3}");
        {



        

 else if (n1 < n2 || n1 < n3)
{
    Console.WriteLine($"o primeiro numero é menor");
    
}
















        }
        
    }

}