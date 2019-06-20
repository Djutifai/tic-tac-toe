using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board brd = new Board();
            Player player1 = new Player();
            brd.Start(player1,brd);
            Console.ReadLine();
        }
    }
}
