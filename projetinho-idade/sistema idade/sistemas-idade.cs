// PEGAR MINHA IDADE
// DESMENBRAR ELA EM MESSES
// DESMENBRAR RESULTADO DOS MESES EM DIAS
// DESMENBRAR RESULTADO DOS DIAS EM HORAS
// DESMENBRAR RESULTADO DAS HORAS EM MINUTOS

    Console.WriteLine(@$"
    =====================
    |     S.P.C.I       |
    =====================
    
    ");
    
Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

int meses = (idade * 12);

int dias = (meses * 30);

int horas = (dias * 24);

float minutos = (horas * 60);

Console.WriteLine($"{nome}, sua idade é {idade}, você tem {meses} meses, {dias} dias, {horas} horas, {minutos} minutos");

Console.WriteLine($"OBRIGADO POR UTILIZAR O SISTEMA PRECISO DE CALCULO DE IDADE S2!");

