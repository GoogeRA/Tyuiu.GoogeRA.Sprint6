using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.GoogeRA.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[1, i] % 2 == 0)
                {
                    matrix[1, i] = 4;
                }
            }
            return matrix;

        }
    }
}
