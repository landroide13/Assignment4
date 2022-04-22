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

        //static private int cb;

        public Player(string Name, int Budget, int[] Numbers)
        {
            this.Name = Name;
            this.Budget = Budget;
            this.Numbers = Numbers;
        }

        public Player(){}

        public int GetBudget()
        {
            return Budget;
        }

        public string GetName()
        {
            return Name;
        }

        public void WeekNumber(Lottery lottery)
        {
            Console.WriteLine("The Number of the Week is: " + lottery.number);
        }

        public void CheckNumber(Lottery lottery)
        {
            foreach(int num in Numbers)
            {
                if(Budget > 0)
                {
                     if(num == lottery.number)
                    {
                        Budget = Budget - 1;
                        Console.WriteLine("****** WINNER ******");
                        Console.WriteLine("We have a Winner, Congrats to: " +  Name + " ,Remining Budget: " + Budget);
                        Console.WriteLine("*******************");
                        
                    }
                }
                else
               {
                    Console.WriteLine(Name + " ,Is out budget");
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