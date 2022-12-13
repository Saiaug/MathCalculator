using MathCalculator.Controller;
using Xunit;
using MathCalculator;
using Math = MathCalculator.Math;

namespace CalculatorControllerTest
{
    public class CalculatorControllerTest
    {
        private Math _maths;
        //private readonly Math _math;

        public CalculatorControllerTest() 
        {
            _maths = new Math();
        }
        [Fact]
        public void Add()
        {
            
                //arrange
                int a = 5;
                int b = 3;
                int expected = 8;

                //act
                var actual = _maths.sum(a, b);

                //Assert
                Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void Subtarct()
        {
            
                //arrange
                int a = 5;
                int b = 3;
                int expected = 2;

                //act
                var actual = _maths.sub(a, b);

                //Assert
                Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void Mul()
        {
            
                //arrange
                int a = 5;
                int b = 3;
                int expected = 15;

                //act
                var actual = _maths.mul(a, b);

                //Assert
                Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void Div()
        {
            
                //arrange
                int a = 10;
                int b = 2;
                int expected = 5;

                //act
                var actual = _maths.div(a, b);

                //Assert
                Assert.Equal(expected, actual);
            
        }
    }
}