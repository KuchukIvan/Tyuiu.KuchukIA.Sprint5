using System.IO;
using Tyuiu.KuchukIA.Sprint5.Task0.V20.Lib;
namespace Tyuiu.KuchukIA.Sprint5.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string file = "OutPutFileTask0.txt";
            string directory = Path.GetTempPath();
            string path = Path.Combine(directory, file);




            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
