using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oselo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ゲームを作成
            Game game = new Game();
            
            //初期配置
            game.SetInitialPosition();

            //
            while (true)
            {
                Console.WriteLine("");
                ShowNextPayer(game.nextPlayer);
                ShowBorad(game.board);
                if (!game.PutStone(game.GetPoint(ReadSelectPoint()), game.nextPlayer))
                {
                    Console.WriteLine("その場所にはおけません");
                }
                else
                {
                    game.NextPalyer(game.nextPlayer);
                }
            }
        }

        private static int[] ReadSelectPoint()
        {
            string nyuryoku = "";
            string[] selectPoint = new string[2];
            int[] point = new int[2];

            while (true)
            {
                Console.Write("置く場所を指定してください(x,y)");
                nyuryoku = Console.ReadLine();
                selectPoint = nyuryoku.Split(',');

                if (CheckPoint(nyuryoku, selectPoint, point))
                {
                    return point;
                }
                Console.WriteLine("入力が誤りです。");
            }
        }

        private static bool CheckPoint(string nyuryoku, string[] selectPoint, int[] point)
        {
            if(nyuryoku.Split(',').Length == 2 && int.TryParse(selectPoint[0], out point[0]) && int.TryParse(selectPoint[1], out point[1]))
            {
                return point[0] >= 1 && point[0] <= 8 && point[1] >= 1 && point[1] <= 8;
            }
            else
            {
                return false;
            }
            
        }

        private static void ShowBorad(Board board)
        {
            Console.WriteLine("　ＡＢＣＤＥＦＧＨ");
            for(int i = 1;i<=8;i++)
            {
                Console.Write(" " + i);
                for(int j = 1;j<=8;j++)
                {
                    if(board.GetCell(new CellPoint(j, i)).Stone == null)
                    {
                        Console.Write("□");
                    }
                    else
                    {
                        if (board.GetCell(new CellPoint(j, i)).Stone.Color == StoneColor.Black)
                        {
                            Console.Write("○");
                        }
                        else
                        {
                            Console.Write("●");
                        }
                    }
                    if(j==8)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

        private static void ShowNextPayer(Player player)
        {
            if(player.Color == StoneColor.Black)
            {
                Console.WriteLine("黒のターンです");
            }
            else
            {
                Console.WriteLine("白のターンです");
            }
        }
    }
}
