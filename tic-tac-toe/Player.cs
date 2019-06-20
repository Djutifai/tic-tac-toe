using System;

namespace tic_tac_toe
{
    class Player
    {

        
        private string _input;
        private int _turn;
        public void Turn(Board board)
        {
            
            _input = Console.ReadLine();
            _turn = Convert.ToInt32(_input);
            switch (_turn)
            {
                case 1: board.Turn(2, 0);
                    break;
                case 2: board.Turn(2, 1);
                    break;
                case 3: board.Turn(2, 2);
                    break;
                case 4: board.Turn(1, 0);
                    break;
                case 5: board.Turn(1, 1);
                    break;
                case 6: board.Turn(1, 2);
                    break;
                case 7: board.Turn(0, 0);
                    break;
                case 8: board.Turn(0, 1);
                    break;
                case 9: board.Turn(0, 2);
                    break;
                default:
                    Console.Write("Error");
                    break;
                        }
            
        }
    }
}
