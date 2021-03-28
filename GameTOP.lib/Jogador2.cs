using System;
using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : iJogador
    {
         
        public string Chuta()
        {
            return "Maradona está chutando \n";
        }

        public string Corre()
        {
            return "Maradona está correndo \n";
        }

        public string Passe()
        {
            return "Maradona está passando \n";
        }
        /* public static string Digite()
        {
            return $"{Console.ReadLine()}";
        }*/
    }
}