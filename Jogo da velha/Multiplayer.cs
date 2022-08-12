using System;
using System.Threading;

namespace Jogo_da_velha
{
    internal class Multiplayer : Funcoes
    {
        public Multiplayer()
        {

            Console.Clear();

            Console.WriteLine("Você escolhe modo Multiplayer\n" +
                "Primeiramete vamos saber seus nomes:\n" +
                "Nome 1:");
            nome1 = Console.ReadLine();

            Console.WriteLine("nome 2:");
            nome2 = Console.ReadLine();


            Jogo();

        }

        private void Jogo()
        {
            for (int i = 0; i < 5; i++)
            {

                Console.Clear();

                Console.WriteLine($"{nome1} (X)\n");

                Tabela();

                Console.WriteLine("\nTabela atual:");

                MostrarTabela();

                Jogador1();

                if (VitoriaJogador1() == true)
                {

                    Console.WriteLine($"{nome1} Venceu!!!");

                    break;

                }

                if (i == 4)
                {
                    Console.WriteLine("Jogo deu velha");

                    break;
                }

                MostrarTabela();


                Thread.Sleep(3000);


                Console.Clear();

                Console.WriteLine($"{nome2} (O)\n");

                Tabela();

                Console.WriteLine("\nTabela atual:");

                MostrarTabela();

                Jogador2();

                if (VitoriaJogador2() == true)
                {

                    Console.WriteLine($"{nome2} Venceu!!!");

                    break;

                }

                MostrarTabela();


                Thread.Sleep(3000);

            }
        }
    }
}
