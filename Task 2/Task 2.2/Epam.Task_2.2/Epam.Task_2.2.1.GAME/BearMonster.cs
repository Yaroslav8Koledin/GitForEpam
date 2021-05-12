namespace Epam.Task_2._2._1.GAME
{
    public class BearMonster : Monsters
    {
        public BearMonster(int _x, int _y) : base(_x, _y)
        {
            Name= "Bear"; 
        }

        public override void Step()
        {
            if (X < Field.Width / 2 && Y < Field.Heigth / 2)
            {
                Y++;
            }
            else if (X > Field.Width / 2 && Y > Field.Heigth / 2)
            {
                Y--;
            }
            else if (X > Field.Width / 2 && Y == Field.Heigth / 2)
            {
                X--;
            }
            else
            {
                X++;
            }
        }
    }
}
