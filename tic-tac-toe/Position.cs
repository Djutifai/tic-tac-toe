using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class Position
    {
        public int Row { get; }
        public int Column { get; }
        public Position (int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
