using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWorldCupLibrary
{
    public class MainMenu
    {
        private IMenu _menu;

        public MainMenu(IMenu menu)
        {
            _menu = menu;
        }

        public string Ans { get => _menu.Ans;  set =>_menu.Ans = value; }
        public int Choice { get => _menu.Choice; set => _menu.Choice = value; }

        public void DoStart()
        {
            _menu.Start();
        }

        public void DoFinish()
        {
            _menu.Finish();
        }

        public bool DoAllowContinue()
        {
            return _menu.AllowContinue();
        }

    }
}
