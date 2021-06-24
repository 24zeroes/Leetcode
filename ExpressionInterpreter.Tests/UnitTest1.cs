using NUnit.Framework;

namespace ExpressionInterpreter.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Addition()
        {
            var input = "1+1";
            App.ExpressionInterpreter ei = new App.ExpressionInterpreter(input);

            var result = ei.Calculate();
            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void Subtraction()
        {
            var input = "10-1";
            App.ExpressionInterpreter ei = new App.ExpressionInterpreter(input);

            var result = ei.Calculate();
            Assert.AreEqual(9, result);
        }
        
        [Test]
        public void Multiplication()
        {
            var input = "10*19";
            App.ExpressionInterpreter ei = new App.ExpressionInterpreter(input);

            var result = ei.Calculate();
            Assert.AreEqual(190, result);
        }
        
        [Test]
        public void Division()
        {
            var input = "10/2";
            App.ExpressionInterpreter ei = new App.ExpressionInterpreter(input);

            var result = ei.Calculate();
            Assert.AreEqual(5, result);
        }
    }
}