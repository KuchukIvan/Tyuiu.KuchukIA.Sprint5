using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KuchukIA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            string allText = File.ReadAllText(path);

            string[] numbers = allText.Split(' ');

            foreach (string value in numbers)
            {
                string formattedNum = value.Replace('.', ',');

                double numb = Convert.ToDouble(formattedNum);

                if ((numb > 10 && numb < 100) || (numb < -9) && (numb > -100))
                {
                    res = res * numb;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
