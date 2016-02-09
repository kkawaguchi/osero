using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Player:IPlayer
    {
       
        public StoneColor Color { get; private set; }
        public String Name { get; private set; }
        public Player(StoneColor color)
        {
            this.Color = color;
            Console.WriteLine("名前を入力してください");
            this.Name = Console.ReadLine();
        }

        public int[] SelectPoint(Board boad)
        {
            return ReadSelectPoint();
        }

        public int[] ReadSelectPoint()
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

                if (CheckPoint2(nyuryoku, selectPoint, point))
                {
                    return point;
                }
                Console.WriteLine("入力が誤りです。");
            }
        }

        private bool CheckPoint(string nyuryoku, string[] selectPoint, int[] point)
        {
            if (nyuryoku.Split(',').Length == 2 && int.TryParse(selectPoint[0], out point[0]) && int.TryParse(selectPoint[1], out point[1]))
            {
                return point[0] >= 1 && point[0] <= 8 && point[1] >= 1 && point[1] <= 8;
            }
            else
            {
                return false;
            }

        }

        private bool CheckPoint2(string nyuryoku, string[] selectPoint, int[] point)
        {
            if (nyuryoku.Length == 2 && int.TryParse(ConvertA(nyuryoku[0].ToString()), out point[0]) && int.TryParse(nyuryoku[1].ToString(), out point[1]))
            {
                return point[0] >= 1 && point[0] <= 8 && point[1] >= 1 && point[1] <= 8;
            }
            else
            {
                return false;
            }

        }

        private string ConvertA(string A)
        {
            switch (A.ToLower())
            {
                case "a": return "1";
                case "b": return "2";
                case "c": return "3";
                case "d": return "4";
                case "e": return "5";
                case "f": return "6";
                case "g": return "7";
                case "h": return "8";
                default: return A;
            }
        }

        
    }
}
