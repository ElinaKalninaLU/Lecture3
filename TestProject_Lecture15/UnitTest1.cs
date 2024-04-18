using System.Drawing;

namespace TestProject_Lecture15
{
    public class UnitTest1
    {
        [Fact]
        public void RectangleArea_h2w2_area4()
        {
            var rect = new GeometryClasses.Rectangle(2, 2);
            Assert.Equal(4, rect.Area);
        }

        [Theory]
        [InlineData(2,3,6)]
        [InlineData(1, 5, 5)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 5, 10)]
        public void RectangleArea_hwarea_true(int h, int w, int area)
        {
            //arrange
            var rect = new GeometryClasses.Rectangle(h, w);
            //act
            int areavalue = rect.Area;
            //assert
            Assert.Equal(area, areavalue);
        }

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }
        int Add(int x, int y)
        {
            return x + y;
        }

    }
}