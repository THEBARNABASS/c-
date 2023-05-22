using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogadoresDeFutebol
{
    class Defesa : Jogador
    {
        private int tempoAposentadoria;
        private int aposentadoria = 40;
        public override int CalcularAposentadoria()
        {
            return tempoAposentadoria = aposentadoria - Idade;
        }
    }
}