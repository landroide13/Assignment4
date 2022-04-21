using System;

namespace demo
{
    interface IPlayer
    {
        void Update(Lottery lottery);
    }
    class Player:IPlayer
   {
        private string Name { get; set; }

        private int[] Numbers { get; set; }
        private int Budget{ get; set; }
        private Lottery lottery { get; set; }

        public Player(string Name, int Budget, int[] Numbers)
        {
            this.Name = Name;
            this.Budget = Budget;
            this.Numbers = Numbers;
        }

        public void Update(Lottery lottery)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", Name, lottery.number);
        }

        public Lottery Lottery
        {
            get { return lottery; }
            set { lottery = value; }
        }
        
    }

}