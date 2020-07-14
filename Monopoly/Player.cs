namespace Monopoly
{
    internal class Player
    {
        string name;
        int money;
        int position;
        public Player()
        {
            name = "Default";
            money = 1000;
            position = 0;
        }

        public Player(string name, int money)
        {
            this.name = name;
            this.money = money;
            position = 0;
        }
    }
}