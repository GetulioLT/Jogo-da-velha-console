using System;

namespace Jogo_da_velha
{
    internal class Jogo
    {
        private int escolha;

        public Jogo()
        {

            Console.WriteLine("Vamos jogar jogo da velha?\n" +
                "É simples jogaremos usando posições que vão do 0 até 2\n" +
                "Olhe um exemplo:");

            Console.WriteLine("[0,0]  [0,1]  [0,2]\n" +
                "[1,0]  [1,1]  [1,2]\n" +
                "[2,0]  [2,1]  [2,2]");

            Console.WriteLine("\nPrimeiro precisamos saber se irá ser uma partida solo ou multiplayer:\n" +
                "1 - solo\n" +
                "2 - para multiplayer");

        vEscolha:

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    Solo();

                    break;


                case 2:

                    Multiplayer();

                    break;


                default:

                    Console.WriteLine("Digite uma escolha valida:");

                    goto vEscolha;

            }

        }

        private void Multiplayer()
        {

            Multiplayer multiplayer = new Multiplayer();
        }

        private void Solo()
        {
            Solo solo = new Solo();
        }
    }


}
