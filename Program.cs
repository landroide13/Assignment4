﻿using System;

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
            Console.WriteLine("**** Welcome to the Simple Lotto ****");

            Console.WriteLine("******* Welcome... ***********");

           
        }

    }        
}
