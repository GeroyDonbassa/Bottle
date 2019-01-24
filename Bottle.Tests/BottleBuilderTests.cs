using NUnit.Framework;

namespace Bottle.Tests
{
    [TestFixture(Description =
        "Единственный тест для проверки построения с разными значениями параметров." +
        "Ставить игнор, когда не нужен, так как проверить результат можно только наглядно, либо выпадет исключение.")]
    //[Ignore("Не нужен")]
    public class BottleBuilderTests
    {
        private KompasConnector _kompasConnector;

        [SetUp]
        public void SetUp()
        {
            // Компас стартует один раз, чтоб не множить окна, а просто в разных документах делать.
            _kompasConnector = new KompasConnector();
            _kompasConnector.Start();
        }

        [Test]
        [TestCase(30, 67, 10, 20, 101)]
        public void BuildBottle(double baseDiameter, double baseLength, double bottleneckDiameter,
            double bottleneckLength, double lengthFullBottle)
        {
            var bottleParameters = new BottleParameters(baseDiameter, baseLength, bottleneckDiameter, bottleneckLength,
                lengthFullBottle);

            var bottleBuilder = new BottleBuilder(_kompasConnector.CreateDocument3D(), bottleParameters);

            bottleBuilder.BuildBottle();
        }
    }
}