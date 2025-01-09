using Calculator.Controllers;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorTest
{
    public class CalcTest
    {
        [Fact]
        public void AddTest()
        {
            //Starting Values
            Calc calc = new Calc { Num1 = 5, Num2 = 15 };
            int expected = 20;

            var controller = new CalculatorController();

            var result = controller.Add(calc) as ViewResult;
            var model = (Calc)result.ViewData.Model;
            int actual = model.Total;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideTest()
        {
            Calc calc = new Calc { Num1 = 15, Num2 = 5 };
            int expected = 3;

            var controller = new CalculatorController();

            var result = controller.Divide(calc) as ViewResult;
            var model = (Calc)result.ViewData.Model;
            int actual = model.Quotient;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideExceptionTest()
        {
            // Arrange
            int n1 = 15;
            int n2 = 0;
            var controller = new CalculatorController();

            //Act + Assert
            Assert.Throws<DivideByZeroException>(() => controller.Divide(new Calc { Num1 = n1, Num2 = n2 }));
        }
    }
}