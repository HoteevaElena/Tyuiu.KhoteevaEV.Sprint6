using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhoteevaEV.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {
        public int[,] GetMatrix(string path)
        {
            int t = 10;

            string[] mass = File.ReadAllLines(path);
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = mass[i].Replace(";", " ");
            }

            int[,] matr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                int[] row = mass[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < t; j++)
                {
                    matr[i, j] = row[j];
                }
            }

            int x = 4;
            for (int j = 0; j < 10; j++)
            {
                if (Math.Abs(matr[x, j]) % 2 != 0)
                {
                    matr[x, j] = -1;
                }
            }

            return matr;
        }
    }
}
