using System.IO;
using Tyuiu.KuchukIA.Sprint5.Task3.V3.Lib;
namespace Tyuiu.KuchukIA.Sprint5.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string file = "OutPutFileTask3.bin";
            string directory = Path.GetTempPath();
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
