using System;
using NUnit.Framework;

namespace Bottle.Tests
{
    [TestFixture]
    public class BottleParameterTests
    {
        [Test]
        [TestCase(24, 80, 20, 22, 130, TestName = "Диаметр основания меньше минимального (25).")]
        [TestCase(30, 66, 20, 22, 130, TestName =
            "Длина основания меньше минимального (2/3 минимальной длины бутылки = 66.6666).")]
        [TestCase(30, 80, 9, 22, 130, TestName = "Диаметр горлышка меньше минимального (10).")]
        [TestCase(30, 80, 20, 19, 130, TestName =
            "Длина горлышка меньше минимального (1/5 минимальной длины бутылки = 20).")]
        [TestCase(30, 80, 20, 22, 99, TestName = "Длина бутылки меньше минимального (100).")]
        [TestCase(66, 80, 20, 22, 130, TestName = "Диаметр основания больше максимального (65).")]
        [TestCase(30, 87, 20, 22, 130, TestName = "Длина основания больше максимального (2/3 общей длины).")]
        [TestCase(30, 80, 27, 22, 130, TestName =
            "Диаметр горлышка больше максимального (если диаметр основания больше 26, то 26).")]
        [TestCase(25, 80, 26, 22, 130, TestName =
            "Диаметр горлышка больше максимального (если диаметр основания меньше 26, то диаметр основания).")]
        [TestCase(30, 80, 20, 27, 130, TestName = "Длина горлышка больше максимального (1/5 общей длины).")]
        [TestCase(30, 80, 20, 22, 255, TestName = "Длина бутылки больше максимального (254).")]
        public void BottleParametersTest_ArgumentException(double baseDiameter, double baseLength,
            double bottleneckDiameter, double bottleneckLength, double lengthFullBottle)
        {
            Assert.Throws<ArgumentException>(() => new BottleParameters(baseDiameter, baseLength, bottleneckDiameter,
                bottleneckLength, lengthFullBottle));
        }

        [Test]
        [TestCase(30, 67, 10, 20, 101, TestName = "Корректные параметры.")]
        public void BottleParametersTest_Correct(double baseDiameter, double baseLength, double bottleneckDiameter,
            double bottleneckLength, double lengthFullBottle)
        {
            var bottleParameters = new BottleParameters(baseDiameter, baseLength, bottleneckDiameter, bottleneckLength,
                lengthFullBottle);

            Assert.AreEqual(baseDiameter, bottleParameters.BaseDiameter);
            Assert.AreEqual(baseLength, bottleParameters.BaseLength);
            Assert.AreEqual(bottleneckDiameter, bottleParameters.BottleneckDiameter);
            Assert.AreEqual(bottleneckLength, bottleParameters.BottleneckLength);
            Assert.AreEqual(lengthFullBottle, bottleParameters.LengthFullBottle);
        }
    }
}