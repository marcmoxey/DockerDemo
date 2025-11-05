using Xunit;

namespace SampleWebApp
{
    public class Calculation
    {

        [Theory]
        [InlineData(4,3,7)]
        [InlineData(8,3,11)]
        [InlineData(12,13,2.5)]
        public static double Add(double x, double y)
        {
            return x + y;
        }
    }
}
