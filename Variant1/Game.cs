using OTUS_DZ3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ3
{
    internal class Game
    {
        public int MaxValue;
        public int CountAttempts;
        private int HiddenNumber;
        private int Count;

        public Game()
        {
            MaxValue = 100;
            CountAttempts = 10;
            NewGame();
        }

        public int GetCount()
        {
            return Count;
        }

        public void SetParams(int maxValue, int countAttemps)
        {
            MaxValue = maxValue;
            CountAttempts = countAttemps;
        }

        public void NewGame()
        {
            HiddenNumber = new Random().Next(0, MaxValue);
            Count = CountAttempts;
        }

        public ResultGame CheckNumber(int number)
        {
            if (number == HiddenNumber)
                return ResultGame.Winner;

            if (Count == 0)
                return ResultGame.GameOver;

            Count--;

            if (number > HiddenNumber)
            {
                return ResultGame.Less;
            }
            else
            {
                return ResultGame.Greater;
            }
        }
    }
}
