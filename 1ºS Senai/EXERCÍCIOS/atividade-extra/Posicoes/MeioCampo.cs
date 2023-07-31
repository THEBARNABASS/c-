using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogadoresDeFutebol
{
    class MeioCampo : Jogador
    {
        private int tempoAposentadoria;
        private int aposentadoria =38;
        public override int CalcularAposentadoria()
        {
            return tempoAposentadoria = aposentadoria - Idade;
        }
    }
}