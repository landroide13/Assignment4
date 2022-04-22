using System;

namespace demo
{
    class Program
    {
        static int NumGem(int min, int max)
        {
            Random rd = new Random();
            int rand_num = rd.Next(min, max);
            return rand_num;
        } 

        public class Ticket : Lottery
        {
            public Ticket (int Number)
                : base(Number){}
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to the Simple Lotto ****");

            Console.WriteLine("******* Welcome ***********");

            Console.WriteLine();

            int[] TamaTicket = {1, 3, 5, 6, 9};

            int[] BobTicket = {4,7};

            int[] CeasarTicket = {2,8,10};

            int TamaBudget = 6;

            int BobBudget = 3;

            int CaesarBudget = 5;

            Ticket tic1 = new Ticket(NumGem(1, 10));
            tic1.Attach(new Player("Tama", TamaBudget ,TamaTicket));
            tic1.Attach(new Player("Bob", BobBudget, BobTicket));
            tic1.Attach(new Player("Caesar", CaesarBudget, CeasarTicket));

            tic1.number = NumGem(1, 10);
            tic1.number = NumGem(1, 10);
            tic1.number = NumGem(1, 10);
            tic1.number = NumGem(1, 10);
            tic1.number = NumGem(1, 10);
            tic1.number = NumGem(1, 10);
            tic1.number = NumGem(1, 10);
            tic1.number = NumGem(1, 10);

           
        }

    }        
}
