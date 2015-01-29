using System.Collections.Generic;

namespace Codility.PerfectChannel
{
    public class Path
    {
        readonly int _xpos ;
        readonly int _ypos ;
        private readonly int[][] _board;
        private readonly int _move;
        private readonly Path _previousNode;

        public int Move { get { return _move; } }
        public int X { get { return _xpos; } }
        public int Y { get { return _ypos; } }
        public Path PreviousNode { get { return _previousNode; } }

        public void GenerateCallStack(Stack<Path> callStack)
        {
            callStack.Push(this);

            if (PreviousNode != null)
            {
                PreviousNode.GenerateCallStack(callStack);
            }
            
        }

        public Path(int xpos, int ypos, int[][] board, int move, Path previousNode)
        {
            _xpos = xpos;
            _ypos = ypos;
            _board = board;
            _move = move;
            _previousNode = previousNode;
        }

        public List<Path> Next()
        {
            return FindPossiblePaths(_xpos, _ypos, _board, _move);
            
        }

        private  List<Path> FindPossiblePaths(int xpos, int ypos, int[][] board, int move)
        {
            List<Path> paths = new List<Path>();

            var positions = new List<Position>
            {
                new Position {X = xpos + 2, Y = ypos + 1},
                new Position {X = xpos + 2, Y = ypos - 1},
                new Position {X = xpos + 1, Y = ypos + 2},
                new Position {X = xpos + 1, Y = ypos - 2},
                new Position {X = xpos - 1, Y = ypos + 2},
                new Position {X = xpos - 1, Y = ypos - 2},
                new Position {X = xpos - 2, Y = ypos + 1},
                new Position {X = xpos - 2, Y = ypos - 2},
            };

            foreach (var position in positions)
            {
                if (IsMovePossible(position.X, position.Y, board) )
                {
                    if (_previousNode == null || ((_previousNode != null) && (position.X != _previousNode.X || position.Y != _previousNode.Y)))
                    {
                        paths.Add(new Path(position.X, position.Y, board, move + 1, this));    
                    }                    
                }
            }
            return paths;
        }

        private static bool IsMovePossible(int x, int y, int[][] board)
        {
            if (x < 0)
                return false;
            if (x >= board.Length)
                return false;
            if (y < 0)
                return false;
            if (y >= board[0].Length)
                return false;
            if (board[x][y] == 1)
                return false;
            return true;
        }
        public bool IsAtBottomRight()
        {
            if (_xpos == _board.Length-1 && _ypos == _board[0].Length-1)
                return true;

            return false;
        }
    }
}