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

            int[] TamaTicket = {1,3,5};

            int[] BobTicket = {4,12,66};

            int[] CeasarTicket = {1,3,5};

            Ticket tic1 = new Ticket(NumGem(1, 99));
            tic1.Attach(new Player("Tama", 12,TamaTicket));
            tic1.Attach(new Player("Bob", 12, BobTicket));
            tic1.Attach(new Player("Caesar", 12, CeasarTicket));

            tic1.number = NumGem(1, 99);
            tic1.number = NumGem(1, 99);
            tic1.number = NumGem(1, 99);
            tic1.number = NumGem(1, 99);
            

           
        }

    }        
}
