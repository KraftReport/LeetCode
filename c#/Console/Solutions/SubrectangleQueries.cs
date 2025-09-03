using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{ 
    public class SubrectangleQueries
    {
        public int[][] Rectangle { get; set; }

        public SubrectangleQueries(int[][] rectangle)
        {
            this.Rectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        { 
            for(int i = 0; i < this.Rectangle.Length; i++)
            {
                for(int j = 0; j < this.Rectangle[i].Length; j++)
                {
                    if (i >= row1 && j >= col1 && i <= row2 && j <= col2) this.Rectangle[i][j] = newValue;
                }
            }
        }

        public int GetValue(int row, int col)
        {
            return this.Rectangle[row][col];
        }
    }

}
