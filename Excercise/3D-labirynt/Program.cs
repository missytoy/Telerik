using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_labirynt
{
    class Program
    {

        private static char[, ,] matrix;
        private static bool[, ,] matrixIfUsedElement;
        private static Queue<Cell> visited = new Queue<Cell>();
        private static int levels;
        private static int rows;
        private static int cols;
        private static int minPathValue = int.MaxValue;
        private static int currentPathValue = 0;
        private static Stack<Cell> path = new Stack<Cell>();
        private static bool[, ,] used;

        public static void Main()
        {
            int[] start = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => int.Parse(x))
              .ToArray();

            var rowsAndColsAndLevels = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => int.Parse(x))
              .ToArray();

            levels = rowsAndColsAndLevels[0];
            rows = rowsAndColsAndLevels[1];
            cols = rowsAndColsAndLevels[2];

            used = new bool[levels, rows, cols];
            matrix = new char[levels, rows, cols];
            matrixIfUsedElement = new bool[levels, rows, cols];

            matrix = ReadMatrix(levels, rows, cols);
            var startCell = new Cell(start[0], start[1], start[2], 1);

            // FindMaxPath(startCell.Level, startCell.Row, startCell.Col);

            FindMaxPathBFS(startCell.Level, startCell.Row, startCell.Col);



        }

        private static char[, ,] ReadMatrix(int levels, int rows, int cols)
        {
            for (int k = 0; k < levels; k++)
            {
                for (int i = 0; i < rows; i++)
                {
                    var line = Console.ReadLine().ToCharArray();

                    for (int j = 0; j < cols; j++)
                    {
                        matrix[k, i, j] = line[j];
                    }
                }
            }
            return matrix;
        }

        private static bool CheckCell(int level, int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(1) || col < 0 || col >= matrix.GetLength(2))
            {
                return false;
            }

            if (matrix[level, row, col] == '#')
            {
                return false;
            }

            return true;
        }


        private static void FindMaxPathBFS(int level, int row, int col)
        {
            var cell = new Cell(level, row, col, 1);
            used[cell.Level, cell.Row, cell.Col] = true;
            visited.Enqueue(cell);

            while (visited.Count > 0)
            {
                cell = visited.Dequeue();

                if (matrix[cell.Level, cell.Row, cell.Col] == 'D')
                {
                    if (cell.Level == 0)
                    {
                        Console.WriteLine(cell.MaxPath);
                        return;
                    }

                    if (matrix[cell.Level - 1, cell.Row, cell.Col] == '#')
                    {
                        continue;
                    }


                    var newCell = new Cell(cell.Level - 1, cell.Row, cell.Col, cell.MaxPath + 1);
                    used[newCell.Level, newCell.Row, newCell.Col] = true;
                    visited.Enqueue(newCell);

                }

                if (matrix[cell.Level, cell.Row, cell.Col] == 'U')
                {
                    if (cell.Level + 1 >= matrix.GetLength(0))
                    {
                        Console.WriteLine(cell.MaxPath);
                        return;
                    }

                    if (matrix[cell.Level + 1, cell.Row, cell.Col] == '#')
                    {
                        continue;
                    }

                    var newCell = new Cell(cell.Level + 1, cell.Row, cell.Col, cell.MaxPath + 1);
                    used[newCell.Level, newCell.Row, newCell.Col] = true;
                    visited.Enqueue(newCell);
                }

                if (matrix[cell.Level, cell.Row, cell.Col] == '.')
                {
                    // down cell
                    if (cell.Row + 1 < matrix.GetLength(1)
                        && matrix[cell.Level, cell.Row + 1, cell.Col] != '#'
                        && !used[cell.Level, cell.Row + 1, cell.Col])
                    {
                        visited.Enqueue(new Cell(cell.Level, cell.Row + 1, cell.Col, cell.MaxPath + 1));
                        used[cell.Level, cell.Row + 1, cell.Col] = true;
                    }
                    // up cell
                    if (cell.Row - 1 >= 0
                        && matrix[cell.Level, cell.Row - 1, cell.Col] != '#'
                        && !used[cell.Level, cell.Row - 1, cell.Col])
                    {
                        visited.Enqueue(new Cell(cell.Level, cell.Row - 1, cell.Col, cell.MaxPath + 1));
                        used[cell.Level, cell.Row - 1, cell.Col] = true;
                    }
                    // right cell
                    if (cell.Col + 1 < matrix.GetLength(2)
                        && matrix[cell.Level, cell.Row, cell.Col + 1] != '#'
                        && !used[cell.Level, cell.Row, cell.Col + 1])
                    {
                        visited.Enqueue(new Cell(cell.Level, cell.Row, cell.Col + 1, cell.MaxPath + 1));
                        used[cell.Level, cell.Row, cell.Col + 1] = true;
                    }
                    // right cell
                    if (cell.Col - 1 >= 0
                        && matrix[cell.Level, cell.Row, cell.Col - 1] != '#'
                        && !used[cell.Level, cell.Row, cell.Col - 1])
                    {
                        visited.Enqueue(new Cell(cell.Level, cell.Row, cell.Col - 1, cell.MaxPath + 1));
                        used[cell.Level, cell.Row, cell.Col - 1] = true;
                    }
                }
            }
        }

        private static void FindMaxPath(int level, int row, int col)
        {
            if (level < 0 || level >= matrix.GetLength(0))
            {
                if (currentPathValue < minPathValue)
                {
                    minPathValue = currentPathValue;
                }
                return;
            }

            if (!CheckCell(level, row, col))
            {
                return;
            }

            if (matrixIfUsedElement[level, row, col])
            {

                return;
            }
            if (currentPathValue > minPathValue)
            {
                return;
            }


            if (matrix[level, row, col] == 'U')
            {
                currentPathValue += 1;
                matrixIfUsedElement[level, row, col] = true;

                FindMaxPath(level + 1, row, col);

                currentPathValue -= 1;
                matrixIfUsedElement[level, row, col] = false;
                return;
            }

            if (matrix[level, row, col] == 'D')
            {
                currentPathValue += 1;
                matrixIfUsedElement[level, row, col] = true;

                FindMaxPath(level - 1, row, col);


                currentPathValue -= 1;
                matrixIfUsedElement[level, row, col] = false;

                return;
            }

            currentPathValue += 1;

            matrixIfUsedElement[level, row, col] = true;

            FindMaxPath(level, row, col + 1);
            FindMaxPath(level, row + 1, col);
            FindMaxPath(level, row - 1, col);
            FindMaxPath(level, row, col - 1);


            currentPathValue -= 1;

            matrixIfUsedElement[level, row, col] = false;
        }
    }

    public class Cell
    {
        public Cell(int level, int row, int col, int maxPath)
        {
            this.Level = level;
            this.Row = row;
            this.Col = col;
            this.MaxPath = maxPath;
        }

        public int Level { get; set; }

        public int Row { get; set; }

        public int Col { get; set; }
        public int MaxPath { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Row, this.Col);
        }
    }
}
