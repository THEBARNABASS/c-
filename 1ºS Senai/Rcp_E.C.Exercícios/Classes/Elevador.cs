using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rcp_E.C.Exercícios.classes
{
    public class Elevador
    {
        static string PerguntaString(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine().ToLower();
        }

        static char PerguntaChar(string pergunta)
        {
            Console.WriteLine(pergunta);
            return char.Parse(Console.ReadLine());
        }

        static int PerguntaInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }

        static float PerguntaFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            return float.Parse(Console.ReadLine());
        }

        static void ExibeMensagemPulandoLinha(string texto)
        {
            Console.WriteLine(texto);
        }

        static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }

        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            ExibeMensagem(texto);
            for (int i = 0; i <= quantidadePontinhos; i++)
            {
                ExibeMensagem("»");
                Thread.Sleep(tempo);
            }
            ExibeMensagem(">");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public int ground = 0;
        public int floor1 { get; set; }
        public int floor2 { get; set; }
        public int floor3 { get; set; }
        public int floor4 { get; set; }
        public int top = 5;
        public int people;
        public int nmrpeople;
        public void Inicializa()
        {

            BarraCarregamento("Iniciando <", 20, 30);
            ExibeMensagem("");

            ExibeMensagem(@$"
            ----------------------------
             O elevador está no térreo
             Números de pessoas : 0
             Total de 5 andares no prédio
            ----------------------------
            ");

        }
        public void Entrar()
        {
                people = PerguntaInt($"Quantas pessoas vão entar no elevador?");
            
                if (people <= 4)
                {
                    Console.WriteLine($"tem {people} pessoas no elevador");
                }
                else
                {
                    Console.WriteLine($"O elevador comporta apenas 4 pessoas por vez");
                }
        

        }
        public void Sair()
        {
            nmrpeople = PerguntaInt("quantas pessoas vão sair do elevador?");
            if (people > 0 && people <= 4)
            {
                Console.WriteLine($"Então {nmrpeople} saíram do elevador e ficaram {(people - nmrpeople)}");
            }
            else if (people == 0)
            {
                ExibeMensagemPulandoLinha("O elevador está vazio");
            }


        }
            public void subir()
            {
                Console.WriteLine($@"
                @===========@
                | Andar - 0 |
                |-----------|
                | [0] Andar |
                | [1] Andar | 
                | [2] Andar |
                | [3] Andar |
                | [4] Andar |
                | [5] Andar |
                @===========@
                
                
                ");
                
            }
    }
}
