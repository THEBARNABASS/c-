// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.
// COLOCAR UM INPUT PARA O SALARIO
// COLOCAR UM INPUT PARA O VALOR GASTO
// SE O GASTO ">" SALARIO EXIBIR ORÇAMENTO ESTOURADO
// SE O SALARIO ">"
//==================================================================================================================================//
 Console.WriteLine($"Digite aqui o valor do seu salário:");
 float salario = float.Parse(Console.ReadLine());
 
 Console.WriteLine($"Digite aqui o valor dos gastos:");
 float gastos = float.Parse(Console.ReadLine());


 if (salario > gastos)
 {
    Console.WriteLine(@$"
    @===================@
    |  GASTOS DENTRO    | 
    |   DO ORÇAMENTO    |
    @===================@
    ");
 }
 else 
 {
    Console.WriteLine(@$"
    @===================@
    |     ORÇAMENTO     | 
    |     ESTOURADO     |
    @===================@
    "); 
 }
