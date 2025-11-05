using SampleWebApp;

namespace TestProj
{
    public class CalculationTest
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(8, 3, 11)]
        [InlineData(12, 13, 25)]
        public void Add_ShouldWork(double x, double y, double  expected)
        {
            double actual = Calculation.Add(x,y);
            
            Assert.Equal(expected, actual);
        }
    }
}
