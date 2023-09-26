namespace webapi.inlock.codeFirst.manha.Utils
{
	public class Criptografria
	{
		public static string GerarHash(string senha)
		{
			return BCrypt.Net.BCrypt.HashPassword(senha);
		}

		public static bool CompararHash(string senhaform, string senhabanco)
		{
			return BCrypt.Net.BCrypt.Verify(senhaform, senhabanco);
		}
	}
}
