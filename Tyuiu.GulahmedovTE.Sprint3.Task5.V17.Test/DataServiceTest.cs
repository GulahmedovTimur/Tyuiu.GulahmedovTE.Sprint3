using Tyuiu.GulahmedovTE.Sprint3.Task5.V17.Lib;
namespace Tyuiu.GulahmedovTE.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(35.624, ds.GetSumSumSeries(1, 1, 1, 3, 12));
        }
    }
}