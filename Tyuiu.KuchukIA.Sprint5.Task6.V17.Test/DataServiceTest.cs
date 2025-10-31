using System.IO;
using Tyuiu.KuchukIA.Sprint5.Task6.V17.Lib;
namespace Tyuiu.KuchukIA.Sprint5.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string file = "InPutDataFileTask6V17.txt";
            string directory = @"C:\DataSprint5";
            string path = Path.Combine(directory, file);

            int res = ds.LoadFromDataFile(path);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }



        [TestMethod]
        public void CheckedExistsFile()
        {
            string file = "InPutDataFileTask6V17.txt";
            string directory = @"C:\DataSprint5";
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
