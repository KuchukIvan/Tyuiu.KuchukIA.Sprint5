using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KuchukIA.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string file = "OutPutDataFileTask7V25.txt";
            string directory = Path.GetTempPath();
            string pathSave = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSave);
            }

            string text = File.ReadAllText(path);

            text = Regex.Replace(text, "[a-zA-Z]+", "");

            text = Regex.Replace(text, @"\s+\.", ".");

            File.WriteAllText(pathSave, text);

            return pathSave;



        }
    }
}
