using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _Jogador1;
        private readonly iJogador _Jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
        }
          public void IniciarJogo()
          {
             Console.Write(_Jogador1.Corre());
             Console.Write(_Jogador1.Chuta());
             Console.Write(_Jogador1.Passe());

             Console.Write("\n PROXIMO JOGADOR \n");

             Console.Write(_Jogador2.Corre());
             Console.Write(_Jogador2.Chuta());
             Console.Write(_Jogador2.Passe());
          }
    }
}