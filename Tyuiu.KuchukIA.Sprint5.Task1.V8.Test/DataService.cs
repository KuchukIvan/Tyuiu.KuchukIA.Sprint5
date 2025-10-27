using System.IO;
using System.Linq.Expressions;
namespace Tyuiu.KuchukIA.Sprint5.Task1.V8.Test
{
    [TestClass]
    public sealed class DataService
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string file = "OutPutFileTask1.txt";
            string directory = Path.GetTempPath();
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
