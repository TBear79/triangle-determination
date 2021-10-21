using Xunit;
using Shouldly;

namespace TriangleDetermination.Test
{

    public class TriangleBlTests
    {
        [Theory]
        [InlineData(10, 10, 10, TriangleEnum.Iquilateral)]
        [InlineData(10, 10, 20, TriangleEnum.Isosceles)]
        [InlineData(10, 20, 30, TriangleEnum.Scalene)]
        public void Input_ShouldHandle(int side1, int side2, int side3, TriangleEnum expectedResult)
        {
            var result = TriangleBl.DetermineType(side1, side2, side3);

            result.ShouldBe(expectedResult);
        }
    }
}
