using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portals
{
    class Program
    {
        //private static char[,] matrix = new char[,]{
        //{' ', ' ', ' ', '*', ' ', ' ', ' '},
        //{'*', '*', ' ', '*', ' ', '*', ' '},
        //{' ', ' ', ' ', ' ', ' ', ' ', ' '},
        //{' ', '*', '*', '*', '*', '*', ' '},
        //{' ', ' ', ' ', ' ', ' ', ' ', ' '},
        //};

        private static int[,] matrix;
        private static bool[,] matrixIfUsedElement;
        private static int rows;
        private static int cols;
        private static int maxPathValue = 0;
        private static int currentPathValue = 0;
        private static Stack<Cell> path = new Stack<Cell>();

        public static void Main()
        {
            int[] start = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => int.Parse(x))
              .ToArray();

            var rowsAndCols = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => int.Parse(x))
              .ToArray();

            rows = rowsAndCols[0];
            cols = rowsAndCols[1];

            matrix = new int[rows, cols];
            matrixIfUsedElement = new bool[rows, cols];

            matrix = ReadMatrix(rows, cols);
            var startCell = new Cell(start[0], start[1]);

            FindMaxPath(startCell.Row, startCell.Col);

            Console.WriteLine(maxPathValue);


        }

        private static int[,] ReadMatrix(int rows, int cols)
        {

            for (int i = 0; i < rows; i++)
            {
                int number;
                var line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.TryParse(x, out number) ? number : -1)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            return matrix;
        }

        private static bool CheckCell(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            if (matrix[row, col] == -1)
            {
                return false;
            }

            return true;
        }

        private static void FindMaxPath(int row, int col)
        {
            if (!CheckCell(row, col))
            {
                return;
            }

            if (matrixIfUsedElement[row, col])
            {
                return;
            }

            var currentValueInCell = matrix[row, col];
            currentPathValue += currentValueInCell;

            matrixIfUsedElement[row, col] = true;
            FindMaxPath(row - currentValueInCell, col);
            FindMaxPath(row, col - currentValueInCell);
            FindMaxPath(row, col + currentValueInCell);
            FindMaxPath(row + currentValueInCell, col);

            if (currentPathValue > maxPathValue)
            {
                maxPathValue = currentPathValue;
            }


          //  if (CheckCell(row - currentValueInCell, col) || CheckCell(row, col - currentValueInCell)
          //      || CheckCell(row, col + currentValueInCell) || CheckCell(row + currentValueInCell, col))
          //  {
          //      
          //  }

            currentPathValue -= currentValueInCell;

            matrixIfUsedElement[row, col] = false;
        }
    }

    public class Cell
    {
        public Cell(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Row, this.Col);
        }
    }
}
