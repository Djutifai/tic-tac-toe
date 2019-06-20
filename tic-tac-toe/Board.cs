using System;

namespace tic_tac_toe
{
    class Board
    {
        private State[,] _sqrs = new State[3,3];
        private bool _isWorking = true;
        private State _Player = State.O;
        private Winchecker _winChecker = new Winchecker();
        
        public void Start(Player p1,Board board)
        {                 

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    _sqrs[x,y] = State.Undecided;
                }

            }

            Print();
            while (_isWorking)
            {
                p1.Turn(this);
                
            }
            Console.ReadLine();
            
        }
        private void Print()
        {
            
            Console.WriteLine("Welcome to the Tic-Tac-Toe!");
            Console.WriteLine("++|+-+|++");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (_sqrs[x, y] == State.Undecided)
                        Console.Write(" – ");
                    else if (_sqrs[x, y] == State.O)
                        Console.Write(" O ");
                    else if (_sqrs[x, y] == State.X)
                        Console.Write(" X ");
                    else
                        Console.Write("Error"); 

                }
                Console.WriteLine();
                Console.Write("++|+-+|++");
                Console.WriteLine();           
            }

            if (_Player==State.O)  Console.Write("Player 1, make your turn: "); 
            else if (_Player==State.X)  Console.Write("Player 2, now its your turn: "); 

        }
        public void Turn(int x, int y)
        {
            
            if (_sqrs[x, y] == State.Undecided)
            {
                if (_Player==State.O)
                {

                    _sqrs[x, y] = _Player;
                    _Player = State.X;

                }
                else if (_Player==State.X)
                {
                    _sqrs[x, y] = _Player;
                    _Player = State.O;
                }
            }
            else
            {
                Console.Write("Im sorry, this cell is already locked");
                Console.ReadKey();
            }
            Console.Clear();
            Print();
            WinCheck();
            
        }
        private void WinCheck()
        {
            if (_winChecker.Check(this) != State.Undecided) Win(_winChecker.Check(this));
            if (_winChecker.IsDraw(this)) { Console.Clear(); Console.WriteLine("A draw!"); _isWorking = false; }
            
        }
        
        private void Win(State state)
        {
            Console.Clear();
            if (state==State.O) Console.Write("Player one, congratulations, you have won!");
            else if (state==State.X) Console.Write("Player two, congratulations, you have won!");
            _isWorking = false;
            
        }
        public State getState (Position position)
        {
            return _sqrs[position.Row,position.Column];
        }
    }
}
