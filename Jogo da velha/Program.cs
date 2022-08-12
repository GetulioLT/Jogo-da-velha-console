using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_velha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos jogar jogo da velha?");
            Console.WriteLine("É simples jogaremos usando posições que vão do 0 até 2");
            Console.WriteLine("Olhe um exemplo:");
            Console.WriteLine("[0,0]  [0,1]  [0,2]");
            Console.WriteLine("[1,0]  [1,1]  [1,2]");
            Console.WriteLine("[2,0]  [2,1]  [2,2]");

            Console.WriteLine();

            /*================ Váriaveis ================*/

            char[,] tabuleiro = new char[3, 3];

            tabuleiro[0, 0] = '-';
            tabuleiro[1, 0] = '-';
            tabuleiro[2, 0] = '-';

            tabuleiro[0, 1] = '-';
            tabuleiro[1, 1] = '-';
            tabuleiro[2, 1] = '-';

            tabuleiro[0, 2] = '-';
            tabuleiro[1, 2] = '-';
            tabuleiro[2, 2] = '-';

            bool a11 = false;
            bool a21 = false;
            bool a31 = false;

            bool b11 = false;
            bool b21 = false;
            bool b31 = false;

            bool c11 = false;
            bool c21 = false;
            bool c31 = false;

            bool a12 = false;
            bool a22 = false;
            bool a32 = false;

            bool b12 = false;
            bool b22 = false;
            bool b32 = false;

            bool c12 = false;
            bool c22 = false;
            bool c32 = false;

            int k = 0;
            int l = 0;
            int c = 1;
            int d = 1;
            int e = 0;
            int f = 0;

            /*===========================================*/

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    if (d < 3)
                    {
                        Console.Write($"{tabuleiro[e, f]} ");

                        f++;
                    }
                    else
                    {

                        Console.Write($"{tabuleiro[e, f]}");
                        Console.WriteLine();

                        f = 0;
                        e++;
                        d = 0;
                    }
                    d++;
                    c++;
                }
            }
            e = 0;
            f = 0;

            for (int i = 0; i < 5; i++)
            {

                //jogador 1
                Console.WriteLine("Jogador 1(X)");
            ret1:
            ret11:

                /*============ Entrada de Dados =============*/

                Console.WriteLine("Linha:");
                Console.Write("");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna:");
                Console.Write("");
                l = int.Parse(Console.ReadLine());

                /*===========================================*/

                /*========= Processamento de Dados ==========*/

                if (k > 3 || l > 3)
                {
                    goto ret1;
                }

                if (k == 0 && l == 0 && a12 == false && a11 != true)
                {
                    a11 = true;

                    tabuleiro[0, 0] = 'X';
                }
                else if (k == 0 && l == 1 && a22 == false && a21 != true)
                {
                    a21 = true;

                    tabuleiro[0, 1] = 'X';
                }
                else if (k == 0 && l == 2 && a32 == false && a31 != true)
                {
                    a31 = true;

                    tabuleiro[0, 2] = 'X';
                }
                else if (k == 1 && l == 0 && b12 == false && b11 != true)
                {
                    b11 = true;

                    tabuleiro[1, 0] = 'X';
                }
                else if (k == 1 && l == 1 && b22 == false && b21 != true)
                {
                    b21 = true;

                    tabuleiro[1, 1] = 'X';
                }
                else if (k == 1 && l == 2 && b32 == false && b31 != true)
                {
                    b31 = true;

                    tabuleiro[1, 2] = 'X';
                }
                else if (k == 2 && l == 0 && c12 == false && c11 != true)
                {
                    c11 = true;

                    tabuleiro[2, 0] = 'X';
                }
                else if (k == 2 && l == 1 && c22 == false && c21 != true)
                {
                    c21 = true;

                    tabuleiro[2, 1] = 'X';
                }
                else if (k == 2 && l == 2 && c32 == false && c31 != true)
                {
                    c31 = true;

                    tabuleiro[2, 2] = 'X';
                }
                else
                {
                    Console.WriteLine("numero não dentro da tabela escreva novamente: ");

                    goto ret11;
                }

                /*===========================================*/

                Console.WriteLine();

                /*============= Saída de Dados ==============*/

                for (int a = 0; a < 3; a++)
                {
                    for (int b = 0; b < 3; b++)
                    {
                        if (d < 3)
                        {
                            Console.Write($"{tabuleiro[e, f]} ");

                            f++;
                        }
                        else
                        {

                            Console.Write($"{tabuleiro[e, f]}");
                            Console.WriteLine();

                            f = 0;
                            e++;
                            d = 0;
                        }
                        d++;
                        c++;
                    }
                }
                e = 0;
                f = 0;

                /*===========================================*/

                Console.WriteLine();


                /*========== Condição de vitória ============*/

                //Jogador1

                if (tabuleiro[0, 0] == 'X' && tabuleiro[0, 1] == 'X' && tabuleiro[0, 2] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }
                else if (tabuleiro[1, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[1, 2] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }
                else if (tabuleiro[2, 0] == 'X' && tabuleiro[2, 1] == 'X' && tabuleiro[2, 2] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }
                else if (tabuleiro[0, 0] == 'X' && tabuleiro[1, 0] == 'X' && tabuleiro[2, 0] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }
                else if (tabuleiro[0, 1] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 1] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }
                else if (tabuleiro[0, 2] == 'X' && tabuleiro[1, 2] == 'X' && tabuleiro[2, 2] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }
                else if (tabuleiro[0, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 2] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }
                else if (tabuleiro[0, 2] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 0] == 'X')
                {
                    Console.WriteLine("Jogador 1 Venceu");

                    break;
                }

                //

                /*===========================================*/

                //velha

                if (i == 4)
                {
                    Console.WriteLine("Jogo deu velha");

                    break;
                }

                //

                //jogador 2


                Console.WriteLine("Jogador 2(O)");
            ret2:
            ret22:

                /*============ Entrada de Dados =============*/

                Console.WriteLine("Linha:");
                Console.Write("");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna:");
                Console.Write("");
                l = int.Parse(Console.ReadLine());

                /*===========================================*/

                /*========= Processamento de Dados ==========*/

                if (k > 3 || l > 3)
                {
                    goto ret2;
                }

                if (k == 0 && l == 0 && a11 == false)
                {
                    a12 = true;

                    tabuleiro[0, 0] = 'O';
                }
                else if (k == 0 && l == 1 && a21 == false)
                {
                    a22 = true;

                    tabuleiro[0, 1] = 'O';
                }
                else if (k == 0 && l == 2 && a31 == false)
                {
                    a32 = true;

                    tabuleiro[0, 2] = 'O';
                }
                else if (k == 1 && l == 0 && b11 == false)
                {
                    b12 = true;

                    tabuleiro[1, 0] = 'O';
                }
                else if (k == 1 && l == 1 && b21 == false)
                {
                    b22 = true;

                    tabuleiro[1, 1] = 'O';
                }
                else if (k == 1 && l == 2 && b31 == false)
                {
                    b32 = true;

                    tabuleiro[1, 2] = 'O';
                }
                else if (k == 2 && l == 0 && c11 == false)
                {
                    c12 = true;

                    tabuleiro[2, 0] = 'O';
                }
                else if (k == 2 && l == 1 && c21 == false)
                {
                    c22 = true;

                    tabuleiro[2, 1] = 'O';
                }
                else if (k == 2 && l == 2 && c31 == false)
                {
                    c32 = true;

                    tabuleiro[2, 2] = 'O';
                }
                else
                {
                    Console.WriteLine("numero não dentro da tabela escreva novamente: ");

                    goto ret22;
                }

                /*===========================================*/

                Console.WriteLine();

                /*============= Saída de Dados ==============*/

                for (int a = 0; a < 3; a++)
                {
                    for (int b = 0; b < 3; b++)
                    {
                        if (d < 3)
                        {
                            Console.Write($"{tabuleiro[e, f]} ");

                            f++;
                        }
                        else
                        {
                            Console.Write($"{tabuleiro[e, f]}");
                            Console.WriteLine();

                            f = 0;
                            e++;
                            d = 0;
                        }
                        d++;
                        c++;
                    }
                }
                e = 0;
                f = 0;



                /*===========================================*/

                Console.WriteLine();

                /*========== Condição de vitória ============*/

                //Jogador2

                if (tabuleiro[0, 0] == 'O' && tabuleiro[0, 1] == 'O' && tabuleiro[0, 2] == '0')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }
                else if (tabuleiro[1, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[1, 2] == 'O')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }
                else if (tabuleiro[2, 0] == 'O' && tabuleiro[2, 1] == 'O' && tabuleiro[2, 2] == 'O')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }
                else if (tabuleiro[0, 0] == 'O' && tabuleiro[1, 0] == 'O' && tabuleiro[2, 0] == 'O')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }
                else if (tabuleiro[0, 1] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 1] == 'O')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }
                else if (tabuleiro[0, 2] == 'O' && tabuleiro[1, 2] == 'O' && tabuleiro[2, 2] == 'O')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }
                else if (tabuleiro[0, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 2] == 'O')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }
                else if (tabuleiro[0, 2] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 0] == 'O')
                {
                    Console.WriteLine("Jogador 2 Venceu");

                    break;
                }

                //

                /*===========================================*/

                Console.WriteLine("[0,0]  [0,1]  [0,2]");
                Console.WriteLine("[1,0]  [1,1]  [1,2]");
                Console.WriteLine("[2,0]  [2,1]  [2,2]");
                Console.WriteLine();

            }

            Console.ReadLine();

        }
    }
}
