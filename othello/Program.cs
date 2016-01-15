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
                Console.WriteLine(ReadSelectPoint()[0]);



            }


        }

        private static int[] ReadSelectPoint()
        {
            string nyuryoku = "";
            string[] selectPoint = new string[2];
            int[] point = new int[2];

            while (true)
            {
                Console.WriteLine("置く場所を指定してください(x,y)");
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
            return nyuryoku.Split(',').Length == 2 && int.TryParse(selectPoint[0], out point[0]) && int.TryParse(selectPoint[1], out point[1]);
        }
    }
}
