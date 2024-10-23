using myCalc;

namespace myCalcTests
{
    [TestFixture]
    public class Tests
    {
        private MyCalc calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new MyCalc();
        }

        [Test]
        public void Addition_Test()
        {
            Assert.AreEqual(4, calculator.Add(2, 2));
            Assert.AreEqual(0, calculator.Add(-1, 1));
            Assert.AreEqual(0, calculator.Add(0, 0));
        }

        [Test]
        public void Subtraction_Test()
        {
            Assert.AreEqual(2, calculator.Subtract(5, 3));
            Assert.AreEqual(-4, calculator.Subtract(0, 4));
            Assert.AreEqual(0, calculator.Subtract(-2, -2));
        }

        [Test]
        public void Multiplication_Test()
        {
            Assert.AreEqual(9, calculator.Multiply(3, 3));
            Assert.AreEqual(-4, calculator.Multiply(-2, 2));
            Assert.AreEqual(0, calculator.Multiply(0, 5));
        }

        [Test]
        public void Division_Test()
        {
            Assert.AreEqual(5, calculator.Divide(10, 2));
            Assert.AreEqual(-5, calculator.Divide(5, -1));
            Assert.AreEqual(0, calculator.Divide(0, 3));
        }

        [Test]
        public void DivisionByZero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
        [Test]
        public void FractionalNumbers_Test()
        {
            Assert.AreEqual(0.5, calculator.Divide(1, 2));
            Assert.AreEqual(-0.25, calculator.Multiply(-0.5, 0.5));
            Assert.AreEqual(1.5, calculator.Add(1, 0.5));
            Assert.AreEqual(0.5, calculator.Subtract(1, 0.5));
        }
        
    }
}