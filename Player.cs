using System;

namespace demo
{
    interface IPlayer
    {
        void WeekNumber(Lottery lottery);
        void CheckNumber(Lottery lottery);
    }
    class Player:IPlayer
   {
        private string Name;
        private int[] Numbers;
        private int Budget;
        private Lottery lottery;

        static private int cb;

        public Player(string Name, int Budget, int[] Numbers)
        {
            this.Name = Name;
            this.Budget = Budget;
            this.Numbers = Numbers;
        }

        public Player(){}

        public void DisplayNumbers(int[] nums)
        {
            foreach(int num in nums)
            {
                string stn = num.ToString();
                Console.Write(" " + stn + " ");
            }
        }

        public void WeekNumber(Lottery lottery)
        {
            Console.WriteLine("The Number of the Week is: " + lottery.number);
        }

        public void CheckNumber(Lottery lottery)
        {
            foreach(int num in Numbers)
            {
                if(num == lottery.number)
                {
                    Console.WriteLine("****** WINNER ******");
                    Console.WriteLine("We have a Winner, Congrats to: " +  Name);
                    Console.WriteLine("*******************");
                    cb++;
                }
            }

            if(Budget <= cb)
            {
              Console.WriteLine("The Player " + Name +"is out of Budget ");
            }
        }
        public void CheckBudget()
        {

        }

        public Lottery Lottery
        {
            get { return lottery; }
            set { lottery = value; }
        }
        
    }

}