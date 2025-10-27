using System.IO;
using Tyuiu.KuchukIA.Sprint5.Task2.V18.Lib;
namespace Tyuiu.KuchukIA.Sprint5.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string file = "OutPutFileTask2.csv";
            string directory = Path.GetTempPath();
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(fileExists, wait);


        }
    }
}
