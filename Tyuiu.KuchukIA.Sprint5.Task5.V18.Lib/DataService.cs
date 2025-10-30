using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KuchukIA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    double numb = Convert.ToDouble(line);
                    if ((numb > 9 && numb < 100) || (numb < -9 && numb > -100))
                    {
                        res = res * numb;
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
