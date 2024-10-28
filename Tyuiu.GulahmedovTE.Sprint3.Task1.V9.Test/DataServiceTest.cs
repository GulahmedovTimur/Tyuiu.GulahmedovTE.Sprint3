using Tyuiu.GulahmedovTE.Sprint3.Task1.V9.Lib;
namespace Tyuiu.GulahmedovTE.Sprint3.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 4;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 5815.752;
            Assert.AreEqual(wait, res);
        }
    }
}