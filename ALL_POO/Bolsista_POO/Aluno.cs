

namespace Bolsista_POO
{
    public class Aluno
    {
        public string nome;

        public string curso;

        public string idade;
        public string rg;
        public bool bolsista;

        public float mediafinal;

        public float mensal;

        public void VerMediaFinal()
        {
          Console.WriteLine(this.mediafinal);
          
        }

        public float VerMensalidade()
        {

        if(this.mediafinal >= 8 && this.bolsista == true) 
        {
          return  (this.mensal * 0.50f);
        }
        if (this.mediafinal >= 6 && this.mediafinal < 8 && this.bolsista == true)
        {
            return (this.mensal * 0.70f);
        }
        else
        {
            return this.mensal;
        }
       
        }

    }
}