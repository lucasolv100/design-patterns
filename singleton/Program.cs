using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton Jogador_1 = Singleton.ObterInstancia;
            Jogador_1.Mensagem("Jogador 1: a bola está comigo");
            
            Singleton Jogador_2 = Singleton.ObterInstancia;
            Jogador_2.Mensagem("Jogador 2: recebeu o lançamento");
            
            Singleton Jogador_3 = Singleton.ObterInstancia;
            Jogador_3.Mensagem("Jogador 3: cabeçeou a bola para o gol");


            Console.ReadKey();
        }
    }
}
