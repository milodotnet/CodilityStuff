using System;
using System.Collections.Generic;

namespace Codility.PerfectChannel
{
    public class KnightShortestPath
    {
        public static List<Path> _paths;

      
        public static int Solve(int[][] board)
        {
            var path = new Path(0, 0, board, 0, null);
            var moves = path.Next();
            var nextmoves = new List<Path>();

            var validMoves = true;
            while (validMoves)
            {
                
                foreach (var move in moves)
                {
                    if (move.IsAtBottomRight())
                    {
                        PrintMoves(move, board);
                        return move.Move;
                    }

                    var validNextMove = move.Next();
                    if (validNextMove != null)
                    {
                        nextmoves.AddRange(validNextMove);
                    }
                }
                
                if (nextmoves.Count > 0)
                {
                    moves = nextmoves;                    
                    nextmoves = new List<Path>();
                }
                else
                {
                    moves = nextmoves;
                    validMoves = false;
                }
            }
            return -1;
        }

        private static void PrintMoves(Path move, int[][] board)
        {
            var callStack = new Stack<Path>();

            move.GenerateCallStack(callStack);

            foreach (var item in callStack)
            {
                PrintMove(item, board);
            }

          
        }
        private static void PrintMove(Path move, int[][] board)
        {
            Console.WriteLine("move gen  {0}", move.Move);
            for (var x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board[x].Length; y++)
                {
                    if (x == move.X && y == move.Y)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(board[x][y]);
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}