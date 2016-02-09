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
            IPlayer player1 = new AIPlayer2(StoneColor.Black);
            IPlayer player2 = new AIPlayer1(StoneColor.White);
           
            while (!game.HasEnd)
            {
                Console.WriteLine("");
                ShowBorad(game.Board);
                Console.WriteLine("");
                ShowNextPayer(player1, player2, game);
                int[] points = new int[2];
                points = NextPlayer(player1, player2, game).SelectPoint(game.Board);
                if (!game.PutStone(points[0], points[1], game.NextTurnColor))
                {
                    Console.WriteLine("その場所にはおけません");
                }
            }
              GameEnd(game);
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
                        Console.Write("・");
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

        private static void ShowNextPayer(IPlayer player1, IPlayer player2, Game game)
        {

            Console.WriteLine("{0}のターンです({1})", NextPlayer(player1, player2, game).Name, game.NextTurnColor);
            
        }

        private static void GameEnd(Game game)
        {
            Console.WriteLine();
            ShowBorad(game.Board);
            Console.WriteLine("終了です");
            if (game.Winner() == StoneColor.Black)
            {
                Console.WriteLine("黒の勝ちです");
            }
            else if (game.Winner() == StoneColor.White)
            {
                Console.WriteLine("白の勝ちです");
            }
            else
            {
                Console.WriteLine("引き分けです");
            }
            Console.WriteLine("Enterで終了");
            string end = Console.ReadLine();
            
        }

       
        private static IPlayer NextPlayer(IPlayer player1,IPlayer player2,Game game)
        {
            return game.NextTurnColor == player1.Color ? player1 : player2;
        }


    }
}
