// // FUNÇÕES

// // CRIANDO UM METODO

// // STATIC == PQ O METODO ESTA DENTRO DA CLASSE PROGAM.CS
// // VOID É UM TIPO DE RETORNO NESTE CASO "VAZIO"
// // MyMethod() = NOME DOMETODO (USAR PASCALCASE)

// // static void MyMethod()
// // {
// //     // bloco de codigo
// // }

// // CRIAR UM METHOD PARA EXIBIR O NOME DE UMA PESSOA, SOBRENOME E EXIBIR "BOMDIA FULANO DE TAL"

// // static void saldacao()
// // {
// //     Console.WriteLine($"Qual o seu nome?");
// //     string nome = Console.ReadLine();

// //     Console.WriteLine($"Qual seu sobrenome?");
// //     string snome = Console.ReadLine();

// //     Console.WriteLine($"Bom dia {nome} {snome} !");
// // }

// // saldacao();

// ////////////////////////////////////////////////////////////////////////////

// // *********SOMA***************

// static float Somar(float n1, float n2)
// {
//     return n1 + n2;
// }
// Console.WriteLine($"informe o primeiro numero:");
// float n1so = float.Parse(Console.ReadLine());

// Console.WriteLine($"informe o segundo numero:");
// float n2so = float.Parse(Console.ReadLine());

// Console.WriteLine($"a some de {n1so} + {n2so} é: {Somar(n1so, n2so)}");

// // // SOMA(PRIMEIRO NUMERO,SEGUNDO NUMERO)

// // CRIAR OS METOTODS PARA AS DEMAIS OPERAÇÕES  MATEMÁTICAS (-,*,/)

// // *********SUBTRAÇÃO***************

// static float Sub(float n1, float n2)
// {
//     return n1 - n2;
// }
// Console.WriteLine($"informe o primeiro numero:");
// float n1sb = float.Parse(Console.ReadLine());

// Console.WriteLine($"informe o segundo numero:");
// float n2sb = float.Parse(Console.ReadLine());

// Console.WriteLine($"a subtração de {n1sb} - {n2sb} é: {Sub(n1sb, n2sb)}");

// // *********MULTIPLICAÇÃO***************

// static float Multi(float n1, float n2)
// {
//     return n1 * n2;
// }
// Console.WriteLine($"informe o primeiro numero:");
// float n1m = float.Parse(Console.ReadLine());

// Console.WriteLine($"informe o segundo numero:");
// float n2m = float.Parse(Console.ReadLine());

// Console.WriteLine($"a multiplição de {n1m} * {n2m} é: {Multi(n1m, n2m)}");

// // *********DIVISÃO***************

// static float Div(float n1, float n2)
// {
//     return n1 / n2;
// }
// Console.WriteLine($"informe o primeiro numero:");
// float n1d = float.Parse(Console.ReadLine());

// Console.WriteLine($"informe o segundo numero:");
// float n2d = float.Parse(Console.ReadLine());

// Console.WriteLine($"a divisão de {n1d} / {n2d} é: {Div(n1d, n2d)}");

// /////////////////////////////////////////////////////////////////////

// static int MostrarHora()
// {
//   return  DateTime.Now.Hour;
// }

// Console.WriteLine($"Agora são: {MostrarHora()} horas");

// //////////////////////////////////////////////////////////////////////////

static void LoadBar(string text,int qntpoint,int time)
{
    // Console.BackgoundColor = ConsoleColor.Yellow;

    Console.Write(text);

    for (int i = 0; i < qntpoint; i++)
    {
        Console.Write($"/");
        Thread.Sleep(time);
        
    }
    // Console.ResetColor();
}
LoadBar("Loading ", 60, 250);

// static void p(string t,string r)
// {
//     Console.WriteLine(t);
//     Console.ReadLine(r);
    
// }

