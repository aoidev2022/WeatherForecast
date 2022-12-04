using weatherforecast.api.Controllers;

namespace weatherforecast.api.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new WeatherForecastController(logger: null);
            var result = controller.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count(), 5);
        }
    }
}