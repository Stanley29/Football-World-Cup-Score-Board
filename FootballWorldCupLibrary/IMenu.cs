using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWorldCupLibrary
{
    public interface IMenu
    {
        string Ans { get; set; }
        int Choice { get; set; }
        void Start();
        void Finish();
        bool AllowContinue();
        bool AllowLoop();
    }
}
