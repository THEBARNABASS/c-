// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.
using phone_POO;

celular c = new celular();


Console.WriteLine($"modelo:");
c.cor = Console.ReadLine();

Console.WriteLine($"cor:");
c.modelo = Console.ReadLine();

Console.WriteLine($"tamanho:");
c.tamanho = Console.ReadLine();

string opc;

Console.WriteLine($"deseja ligar o celular? (s/n)");
string r = Console.ReadLine().ToLower();

Console.WriteLine(c.ligar());
if (r == "s")
{

    do
    {
        Console.WriteLine($@"
[1] app mensagem
[2] app telefone

[0] desligar
");
        opc = Console.ReadLine();

        switch (opc)
        {
            case "1":
                string msg;
                string nmr;
                Console.WriteLine($"deseja enviar mensagem? (s/n)");
                string r3 = Console.ReadLine();
                Console.WriteLine($"");
                Console.WriteLine(r3 == "s" ? "digite a mensagem:" : "");
                Console.WriteLine($"");
                Console.WriteLine(r3 == "s" ? msg = Console.ReadLine() : "");
                Console.WriteLine($"");
                Console.WriteLine(r3 == "s" ? c.msg() : "");

                break;
            case "2":
                Console.WriteLine($"deseja fzr ligacao? (s/n)");
                string r2 = Console.ReadLine();
                Console.WriteLine($"");
                Console.WriteLine(r2 == "s" ? "digite o número:" : "");
                Console.WriteLine($"");
                Console.WriteLine(r2 == "s" ? nmr = Console.ReadLine() : "");
                Console.WriteLine($"");
                Console.WriteLine(r2 == "s" ? c.call() : "");
                break;
            case "0":
                Console.WriteLine($"desligando...");


                break;
            default:
                Console.WriteLine($"opção inválida");

                break;
        }

    } while (opc != "0");

}
else
{
    Console.WriteLine($"");

}
