using System;

namespace demo
{
    abstract class Lottery
    {
        private int Number;
        private List<IPlayer> players = new List<IPlayer>();

        public Lottery(int Num)
        {
            this.Number = Num;
        }
        public void Attach(IPlayer player)
        {
            players.Add(player);
        }
        public void Detach(IPlayer player)
        {
            players.Remove(player);
        }
        public void Game()
        {
            Player pl = new Player(); 

            pl.WeekNumber(this);

            foreach (IPlayer player in players)
            {   
                player.CheckNumber(this);
            }
            Console.WriteLine("");
        }
        public int number
        {
            get { return Number; }
            set
            {
                if (Number != value)
                {
                    Number = value;
                    Game();
                }
            }
        }
    
    }

}