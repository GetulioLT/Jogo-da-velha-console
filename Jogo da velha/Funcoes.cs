using System;

namespace Jogo_da_velha
{
    internal abstract class Funcoes
    {

        private char[,] tabuleiro = new char[3, 3];

        private bool a11 = false, a21 = false, a31 = false;
        private bool b11 = false, b21 = false, b31 = false;
        private bool c11 = false, c21 = false, c31 = false;
        private bool a12 = false, a22 = false, a32 = false;
        private bool b12 = false, b22 = false, b32 = false;
        private bool c12 = false, c22 = false, c32 = false;

        private int linha = 0;
        private int coluna = 0;
        private int d = 1;
        private int x = 0;
        private int y = 0;

        protected Random r = new Random();

        protected string nome1, nome2;

        private bool vitoria1 = false, vitoria2 = false;

        protected Funcoes()
        {

            tabuleiro[0, 0] = '-'; tabuleiro[1, 0] = '-'; tabuleiro[2, 0] = '-';

            tabuleiro[0, 1] = '-'; tabuleiro[1, 1] = '-'; tabuleiro[2, 1] = '-';

            tabuleiro[0, 2] = '-'; tabuleiro[1, 2] = '-'; tabuleiro[2, 2] = '-';

        }

        protected void Tabela()
        {

            Console.WriteLine("[0,0]  [0,1]  [0,2]\n" +
                "[1,0]  [1,1]  [1,2]\n" +
                "[2,0]  [2,1]  [2,2]");

        }

        protected void MostrarTabela()
        {

            Console.WriteLine();

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    if (d < 3)
                    {
                        Console.Write($"{tabuleiro[x, y]} ");

                        y++;
                    }
                    else
                    {

                        Console.Write($"{tabuleiro[x, y]}");
                        Console.WriteLine();

                        y = 0;
                        x++;
                        d = 0;
                    }
                    d++;
                }
            }
            x = 0;
            y = 0;

            Console.WriteLine();

        }

        protected void Jogador1()
        {

        retEscolha1:


        retLinha1:

            Console.WriteLine("Linha:");
            linha = int.Parse(Console.ReadLine());

            if (linha > 3 || linha < 0)
            {
                Console.WriteLine("Digite um numero entre 0 e 2");

                goto retLinha1;

            }

        ret1Coluna1:

            Console.WriteLine("Coluna:");
            coluna = int.Parse(Console.ReadLine());

            if (coluna > 3 || coluna < 0)
            {
                goto ret1Coluna1;
            }

            if (linha == 0 && coluna == 0 && a12 == false && a11 != true)
            {
                a11 = true;

                tabuleiro[0, 0] = 'X';
            }
            else if (linha == 0 && coluna == 1 && a22 == false && a21 != true)
            {
                a21 = true;

                tabuleiro[0, 1] = 'X';
            }
            else if (linha == 0 && coluna == 2 && a32 == false && a31 != true)
            {
                a31 = true;

                tabuleiro[0, 2] = 'X';
            }
            else if (linha == 1 && coluna == 0 && b12 == false && b11 != true)
            {
                b11 = true;

                tabuleiro[1, 0] = 'X';
            }
            else if (linha == 1 && coluna == 1 && b22 == false && b21 != true)
            {
                b21 = true;

                tabuleiro[1, 1] = 'X';
            }
            else if (linha == 1 && coluna == 2 && b32 == false && b31 != true)
            {
                b31 = true;

                tabuleiro[1, 2] = 'X';
            }
            else if (linha == 2 && coluna == 0 && c12 == false && c11 != true)
            {
                c11 = true;

                tabuleiro[2, 0] = 'X';
            }
            else if (linha == 2 && coluna == 1 && c22 == false && c21 != true)
            {
                c21 = true;

                tabuleiro[2, 1] = 'X';
            }
            else if (linha == 2 && coluna == 2 && c32 == false && c31 != true)
            {
                c31 = true;

                tabuleiro[2, 2] = 'X';
            }
            else
            {
                Console.WriteLine("numero não dentro da tabela escreva novamente: ");

                goto retEscolha1;

            }

        }

        protected bool VitoriaJogador1()
        {

            if (tabuleiro[0, 0] == 'X' && tabuleiro[0, 1] == 'X' && tabuleiro[0, 2] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }
            else if (tabuleiro[1, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[1, 2] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }
            else if (tabuleiro[2, 0] == 'X' && tabuleiro[2, 1] == 'X' && tabuleiro[2, 2] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }
            else if (tabuleiro[0, 0] == 'X' && tabuleiro[1, 0] == 'X' && tabuleiro[2, 0] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }
            else if (tabuleiro[0, 1] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 1] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }
            else if (tabuleiro[0, 2] == 'X' && tabuleiro[1, 2] == 'X' && tabuleiro[2, 2] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }
            else if (tabuleiro[0, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 2] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }
            else if (tabuleiro[0, 2] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 0] == 'X')
            {
                Console.WriteLine("Jogador 1 Venceu");

                vitoria1 = true;
            }

            return vitoria1;

        }


        protected void Jogador2()
        {

        retEscolha2:

            Console.WriteLine("Jogador 2(O)");

        retLinha2:

            Console.WriteLine("Linha:");
            linha = int.Parse(Console.ReadLine());

            if (linha > 3 || linha < 0)
            {
                Console.WriteLine("Digite um numero entre 0 e 2");

                goto retLinha2;

            }

        ret1Coluna2:

            Console.WriteLine("Coluna:");
            coluna = int.Parse(Console.ReadLine());


            if (coluna > 3 || coluna < 0)
            {
                goto ret1Coluna2;
            }

            if (linha == 0 && coluna == 0 && a12 == false && a11 != true)
            {
                a11 = true;

                tabuleiro[0, 0] = 'O';
            }
            else if (linha == 0 && coluna == 1 && a22 == false && a21 != true)
            {
                a21 = true;

                tabuleiro[0, 1] = 'O';
            }
            else if (linha == 0 && coluna == 2 && a32 == false && a31 != true)
            {
                a31 = true;

                tabuleiro[0, 2] = 'O';
            }
            else if (linha == 1 && coluna == 0 && b12 == false && b11 != true)
            {
                b11 = true;

                tabuleiro[1, 0] = 'O';
            }
            else if (linha == 1 && coluna == 1 && b22 == false && b21 != true)
            {
                b21 = true;

                tabuleiro[1, 1] = 'O';
            }
            else if (linha == 1 && coluna == 2 && b32 == false && b31 != true)
            {
                b31 = true;

                tabuleiro[1, 2] = 'O';
            }
            else if (linha == 2 && coluna == 0 && c12 == false && c11 != true)
            {
                c11 = true;

                tabuleiro[2, 0] = 'O';
            }
            else if (linha == 2 && coluna == 1 && c22 == false && c21 != true)
            {
                c21 = true;

                tabuleiro[2, 1] = 'O';
            }
            else if (linha == 2 && coluna == 2 && c32 == false && c31 != true)
            {
                c31 = true;

                tabuleiro[2, 2] = 'O';
            }
            else
            {

                Console.WriteLine("numero não dentro da tabela escreva novamente: ");

                goto retEscolha2;

            }

        }

        protected bool VitoriaJogador2()
        {

            if (tabuleiro[0, 0] == 'O' && tabuleiro[0, 1] == 'O' && tabuleiro[0, 2] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }
            else if (tabuleiro[1, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[1, 2] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }
            else if (tabuleiro[2, 0] == 'O' && tabuleiro[2, 1] == 'O' && tabuleiro[2, 2] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }
            else if (tabuleiro[0, 0] == 'O' && tabuleiro[1, 0] == 'O' && tabuleiro[2, 0] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }
            else if (tabuleiro[0, 1] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 1] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }
            else if (tabuleiro[0, 2] == 'O' && tabuleiro[1, 2] == 'O' && tabuleiro[2, 2] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }
            else if (tabuleiro[0, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 2] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }
            else if (tabuleiro[0, 2] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 0] == 'O')
            {
                Console.WriteLine("Jogador 2 Venceu");

                vitoria2 = true;
            }

            return vitoria2;

        }

    }
}
