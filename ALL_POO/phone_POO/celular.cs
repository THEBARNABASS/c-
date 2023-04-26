

namespace phone_POO
{
    public class celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool on;

        // metodos
        
        public string ligar()
        {
            if(on == true)
            {
                return @"
                ligando...";  
            }
            else{
                return "desligado";
                
            }
        }

        public string call()
        {
            return "chamando...";
        }

        public string msg()
        {
            return "enviando sms...";
        }

    }
}