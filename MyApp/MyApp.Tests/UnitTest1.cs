namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact] // [Fact]  simple test
        public void Add_ShouldReturnCorrectSum()
        {
            
            var calc = new Calculator(); // Arrange
            var result = calc.Add(2, 3);   // Act
            Assert.Equal(5, result); // Assert
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(10, 20, 30)]
        [InlineData(-5, 5, 0)]
        public void Add_ShouldReturnSum_ForMultipleInputs(int a, int b, int expected)
        {
            var calc = new Calculator();
            var result = calc.Add(a, b);
            Assert.Equal(expected, result);
        }




        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 20, -10)]
        [InlineData(5, 5, 0)]
        public void Subtract_ForMultipleInputs(int a, int b, int expected)
        {
            var calc = new Calculator();
            var result = calc.Subtract(a, b);
            Assert.Equal(expected, result);
        }



    }
}