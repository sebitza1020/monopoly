namespace Monopoly
{
    internal class Dice
    {
        int value;

        public Dice()
        {
            value = 5;
        }

        public int Roll()
        {
            return value;
        }
    }
}