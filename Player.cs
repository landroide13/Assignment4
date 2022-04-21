using System;

namespace demo
{
    interface IPlayer
    {
        void Update(Lottery lottery);
        void CheckNumber(Lottery lottery);
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
            Console.WriteLine("The Winnning Number of the Week is {0} " +  lottery.number);
        }

        public void CheckNumber(Lottery lottery)
        {
            foreach(int num in Numbers)
            {
                if(num == lottery.number)
                {
                    Console.WriteLine("We have a Winner, Congrats {0} " +  Name);
                }
            }
        }

        public Lottery Lottery
        {
            get { return lottery; }
            set { lottery = value; }
        }
        
    }

}