using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KuchukIA.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            foreach (char symb in strX)
            {

                strX = strX.Replace(".", ",");

            }

            double x = Convert.ToDouble(strX);

            double y = (Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x);

            y = Math.Round(y, 3);

            return y;

        }
    }
}
