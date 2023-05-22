using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogadoresDeFutebol
{
    class Ataque : Jogador
    {
        private int tempoAposentadoria;
        private int aposentadoria =35;
        public override int CalcularAposentadoria()
        {
            return tempoAposentadoria = aposentadoria - Idade;
        }
    }
}