using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class SnakeLogic
    {
        private int appleX;
        private int appleY;

        private Random myLocalRandom = new Random();

        public void createApple(int SIZE, int DOT_SIZE, int[] x, int[] y)  // Генерация координат яблочка
        {
            LabelX:
            appleX = myLocalRandom.Next(1, (SIZE - DOT_SIZE) / DOT_SIZE) * DOT_SIZE;
            for (int i = 0; i < x.Length; i++)
            {
                if (appleX == x[i])
                    goto LabelX;
            }

            LabelY:
            appleY = myLocalRandom.Next(1, (SIZE - DOT_SIZE) / DOT_SIZE) * DOT_SIZE;
            for (int i = 0; i < y.Length; i++)
            {
                if (appleY == x[i])
                    goto LabelY;
            }
        }

        public int getAppleX => appleX;
        public int getAppleY => appleY;
        public int setAppleX(int x) => appleX = x;
        public int setAppleY(int y) => appleY = y;
    }
}
