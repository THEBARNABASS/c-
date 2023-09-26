using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
	public class EstudioDomain
	{
		public int IdEstudio { get; set; }

		[Required(ErrorMessage = "O nome do Estudio é obrigatório!")]
		public string? Nome { get; set; }
	}
}
