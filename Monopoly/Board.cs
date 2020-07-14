using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

namespace Monopoly
{
    internal class Board
    {
        //CommunityChest communityChest = new CommunityChest();
        //Chance chance = new Chance();

        List<Cell> cellList = new List<Cell>();

        public Board() //date de test
        {
            cellList.Add(new Cell { x = 10, y = 10, color = Color.Lavender, propertyName = "Inginerie" });
            cellList.Add(new Cell { x = 50, y = 10, color = Color.Aquamarine, propertyName = "Litere" });
            cellList.Add(new Cell { x = 90, y = 10, color = Color.Beige, propertyName = "Tractoare" });
            cellList.Add(new Cell { x = 130, y = 10, color = Color.ForestGreen, propertyName = "Mucus" });

            int x = 10;
            foreach (Cell cell in cellList)
            {
                cell.x = x;
                x += Constants.cellWidth + 2;
            }
        }

        public void Show(Form f)
        {
            foreach(Cell cell in cellList)
            {
                cell.Show(f);
            }
            f.Refresh();
        }
    }
}