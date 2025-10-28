using System.Globalization;
using System.IO;
namespace Tyuiu.KuchukIA.Sprint5.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string file = "InPutDataFileTask4V25.txt";
            string directory = "C:\\DataSprint5";
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
}
