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
        private int Budget{ get; set; }
        private int[] Ticket { get; set; }

        public Player(string Name, int Budget, int[] Tic)
        {
            this.Name = Name;
            this.Budget = Budget;
            this.Ticket = Tic;
        }
        
    }

}