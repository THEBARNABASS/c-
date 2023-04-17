// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.


        Console.WriteLine(@$"
   @===============@
   | progama menu  |
   |      de       |
   |    bebidas    |
   @===============@
     ↓ ↓ ↓ ↓ ↓ ↓ ↓ 
");
        Console.WriteLine(@$"
#======================#
|   MENU DAS BEBIDAS   |
|       BEBIDAS        |
#======================#
| 1. Agua              |
| -------------------- |
| 2. Suco              |
| -------------------- |
| 3. Refrigerante      |
| -------------------- |
| 4. cerveja           |
| -------------------- |
| 5. Drinks            |
#======================#
 DIGITE O NUMERO ABAIXO:
  ↓  ↓  ↓  ↓  ↓  ↓  ↓ 
");

string escolha = Console.ReadLine();

switch (escolha)
{
     case "1":
     Console.WriteLine($"A bebida escolhida foi Agua.");
     Console.WriteLine($"Acompanha gelo?");
     string geloagua = Console.ReadLine().ToLower();
     

 
        if(geloagua == "sim")
        {
            Console.WriteLine($"Será adicionado gelo a bebida.");  
        }
        else
        {
            Console.WriteLine($"não será adicionado gelo a bebida.");           
        }

            Console.WriteLine($"Preparando sua bebida");
            Console.WriteLine($".........");
            Console.WriteLine($"pronto! S2");
     
     break;

     case "2":
     Console.WriteLine($"A bebida escolhida foi suco.");
     Console.WriteLine($"Acompanha gelo?");
     string gelosuco = Console.ReadLine().ToLower();

      if(gelosuco == "sim")
        {
            Console.WriteLine($"Será adicionado gelo a bebida.");  
        }
        else
        {
            Console.WriteLine($"não será adicionado gelo a bebida.");           
        }

            Console.WriteLine($"Preparando sua bebida");
            Console.WriteLine($".........");
            Console.WriteLine($"pronto! S2");
     
     break;
     
     case "3":
     Console.WriteLine($"A bebida escolhida foi Refrigerante.");
     Console.WriteLine($"Acompanha gelo?");
     string gelorefri = Console.ReadLine().ToLower();

      if(gelorefri == "sim")
        {
            Console.WriteLine($"Será adicionado gelo a bebida.");  
        }
        else
        {
            Console.WriteLine($"não será adicionado gelo a bebida.");           
        }

            Console.WriteLine($"Preparando sua bebida");
            Console.WriteLine($".........");
            Console.WriteLine($"pronto! S2");
     
     break;
     
    case "4":
     Console.WriteLine($"A bebida escolhida foi cerveja.");
     Console.WriteLine($"Acompanha gelo?");
     string gelocerveja = Console.ReadLine().ToLower();

      if(gelocerveja == "sim")
        {
            Console.WriteLine($"Será adicionado gelo a bebida.");  
        }
        else
        {
            Console.WriteLine($"não será adicionado gelo a bebida.");           
        }

            Console.WriteLine($"Preparando sua bebida");
            Console.WriteLine($".........");
            Console.WriteLine($"pronto! S2");
     
     break;
     
     case "5":
     Console.WriteLine($"A bebida escolhida foi drink.");
     Console.WriteLine($"Acompanha gelo?");
     string gelodrinks = Console.ReadLine().ToLower();

      if(gelodrinks == "sim")
        {
            Console.WriteLine($"Será adicionado gelo a bebida.");  
        }
        else
        {
            Console.WriteLine($"não será adicionado gelo a bebida.");           
        }

            Console.WriteLine($"Preparando sua bebida");
            Console.WriteLine($".........");
            Console.WriteLine($"pronto! S2");
     
     break;

     default :

     Console.WriteLine($"A opção escolhida é invalida.");
     break;


}


    
