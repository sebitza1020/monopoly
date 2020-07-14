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
            Panel backgorundPanel = new Panel();
            backgorundPanel.BorderStyle = BorderStyle.Fixed3D;
            backgorundPanel.BackColor = color;
            backgorundPanel.Left = x;
            backgorundPanel.Top = y;
            backgorundPanel.Height = Constants.cellHeight;
            backgorundPanel.Width = Constants.cellWidth;

            Label cellPropertyName = new Label();
            cellPropertyName.Text = propertyName;
            cellPropertyName.Left = Constants.leftDistanceOfPropetyNameInPanel;
            cellPropertyName.Top = Constants.topDistanceOfPropetyNameInPanel;
            backgorundPanel.Controls.Add(cellPropertyName);

            f.Controls.Add(backgorundPanel);
        }
    //    Image image;

    //    Player owner;

        

    }
}