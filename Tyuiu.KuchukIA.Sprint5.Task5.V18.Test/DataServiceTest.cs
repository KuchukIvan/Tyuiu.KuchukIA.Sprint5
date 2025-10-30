using System.IO;
using Tyuiu.KuchukIA.Sprint5.Task5.V18.Lib;
namespace Tyuiu.KuchukIA.Sprint5.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string file = "InPutDataFileTask5V18.txt";
            string directory = @"C:\\DataSprint5";
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);


        }
    }
}
