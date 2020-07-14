using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Monopoly
{
    internal class MonopolyGame
    {
        Board board = new Board();
        List<Player> players = new List<Player>();
        Dice dice = new Dice();

        internal void Start(Form f)
        {
            board.Show(f);
        }
    }
}