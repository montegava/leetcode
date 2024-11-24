using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Microsoft
{
    public class TicTacToe
    {
        private int n;
        private int[,] game;


        public TicTacToe(int n)
        {
            this.n = n;
            this.game = new int[n, n];
        }

        public int Move(int row, int col, int player)
        {
            game[row, col] = player;
            var count = 0;

            // rows chekc
            count = 0;
            for (int j = 0; j < n; j++)
            {
                if (game[row, j] == player)
                {
                    count++;
                    if (count == n)
                        return player;
                }
                else
                    break;
            }

            // cols chekc
            count = 0;
            for (int j = 0; j < n; j++)
            {
                if (game[j, col] == player)
                {
                    count++;
                    if (count == n)
                        return player;
                }
                else
                    break;
            }

            count = 0;
            // diagonal check left - right
            for (int i = 0; i < n; i++)
            {

                if (game[i, i] == player)
                {
                    count++;
                    if (count == n)
                        return player;
                }
            }

            count = 0;
            // diagonal check   right - left
            for (int i = 0; i < n; i++)
            {
                if (game[i, n - 1 - i] == player)
                {
                    count++;
                    if (count == n)
                        return player;
                }
            }


            return 0;
        }
    }

}
