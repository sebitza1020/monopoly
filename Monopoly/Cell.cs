using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Monopoly
{
    internal class Cell
    {
     //   public int index;
        public int x, y;
    //    public int height, width;
        public string propertyName;
     //   public int buyoutPrice;
     //   public int CurrentRent;
       // CellTypes cellType;
    //    List<Tuple<int, int>> rentRange = new List<Tuple<int, int>>();

        public Color color = new Color();

        internal void Show(Form f)
        {
            Panel p = new Panel();
            p.BackColor = color;
            p.Left = x;
            p.Top = y;
            p.Height = p.Width = 36;

            Label cellName = new Label();
            cellName.Text = propertyName;
            cellName.Left = cellName.Top = 10;

            f.Controls.Add(p);
        }
    //    Image image;

    //    Player owner;

        

    }
}