﻿namespace BolingTDD.Data
{
    public class Game
    {
        int score = 0;
        public void Roll(int pins)
        {
            score += pins;
        }

        public int GetScore()
        {
            return score;
        }
    }
}