namespace Epam.Task_2._2._1.GAME
{
    public class WolfMonster : Monsters
    {
        public WolfMonster(int _x, int _y) : base(_x, _y)
        {
            Name = "Wolf";
        }

        public override void Step()
        {
            if (Y < Field.Heigth)
            {
                Y++;
            }
            else if (Y == Field.Heigth)
            {
                Y = 0;
            }
        }
    }
}
