using System;
using Xunit;
using Shouldly;

namespace TriangleDetermination.Test
{

    public class TriangleBlTests
    {
        TriangleBl sut;

        public TriangleBlTests()
        {
            sut = new TriangleBl();
        }

        [Theory]
        [InlineData(10, 10, 10, TriangleEnum.Iquilateral)]
        [InlineData(10, 10, 20, TriangleEnum.Isosceles)]
        [InlineData(10, 20, 30, TriangleEnum.Scalene)]
        public void Input_ShouldHandle(int side1, int side2, int side3, TriangleEnum expectedResult)
        {
            var result = sut.DetermineType(side1, side2, side3);

            result.ShouldBe(expectedResult);
        }
    }
}
