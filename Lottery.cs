using System;

namespace demo
{
    abstract class Lottery
    {
        private int[] Numbers;
        private List<IPlayer> players = new List<IPlayer>();

        public Lottery(int[] Numbers)
        {
            this.Numbers = Numbers;
        }
        public void Attach(IPlayer player)
        {
            players.Add(player);
        }
        public void Detach(IPlayer player)
        {
            players.Remove(player);
        }
        public void Notify()
        {
            foreach (IPlayer player in players)
            {
                player.Update(this);
            }
            Console.WriteLine("");
        }

        


    }

}