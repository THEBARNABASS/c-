using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
	public class JogoDomain
	{
		public int IdJogo { get; set; }
		public int IdEstudio { get; set; }
		[Required(ErrorMessage = "O título do jogo é obrigatório!")]
		public string? Nome { get; set; }
		public string? Descricao { get; set; }
		public DateTime DataLancamento { get; set; }
		public float valor { get; set; }
		public EstudioDomain Estudio { get; set; }
	}
}
