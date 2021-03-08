using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWorldCupLibrary
{
    interface ICupManager
    {
        int UpdateScore(int startValue);
        void FinishGame(Game game, List<Game> summary);

    }
}
