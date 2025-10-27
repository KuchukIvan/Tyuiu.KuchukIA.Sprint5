using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KuchukIA.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string file = "OutPutFileTask1.txt";
            string directory = Path.GetTempPath();
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 * x - 2) != 0)
                {
                    y = Math.Round((4 - (2 * x) + ((2 + Math.Cos(x)) / (2 * x - 2))), 2);
                    strY = Convert.ToString(y);
                }

                else
                {
                    y = 0;
                    strY = Convert.ToString(y);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);

                }

                else
                {
                    File.AppendAllText(path, strY);
                }


            }
            return path;
        }
    }
}
