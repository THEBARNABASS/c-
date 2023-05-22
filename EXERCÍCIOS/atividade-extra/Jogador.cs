namespace JogadoresDeFutebol
{
    abstract class Jogador
    {
        public string Nome { get; set; }
        public int DataDeNascimento { get; set; }
        public int Idade { get;  set; } 
                // Essa propriedade está para ser mudada graças ao método Calcular Idade
        public string Nacionalidade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public void CadastrarJogador()
        {
            Console.WriteLine($"Insira as informações do Jogador");
            Console.WriteLine($"");
            Console.WriteLine($"Qual o nome do Jogador?");
            Nome = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"Qual o ano em que ele nasceu?");
            DataDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine($"");
            Console.WriteLine($"Qual sua nacionalidade?");
            Nacionalidade = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"Qual sua altura?");
            Altura = (float)Math.Round(double.Parse(Console.ReadLine()),2);

        }
        public int CalcularIdade()
        {
            return Idade = DateTime.Now.Year - DataDeNascimento;
        }
        public abstract int CalcularAposentadoria();
    }
}