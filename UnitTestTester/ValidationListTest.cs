using UnitTestController;

namespace UnitTestTester
{
    public class ValidationListTest
    {

        private ValidationList _validation = new ValidationList();
        [Fact]
        public void MustRemoveNegativeNumbers()
        {
            //ARRANGE
            var list = new List<int> {5, -1, -8, 9};
            var expectedResult = new List<int> {10,4};

            //ACT
            var result = _validation.RemoveNegativeNumbers(list); 

            //ASSERT
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MustContainsNumber9()
        {
            //ARRANGE
            var list = new List<int> {5, -1, -8, 9};
            var numberForFind = 9;

            //ACT
            var result = _validation.ListContainsNumber(list, numberForFind);

            //ASSERT
            Assert.True(result);
        }

        [Fact]
        public void MustNotContains10InList()
        {
            //ARRANGE
            var list = new List<int> {5, -1, -8, 9};
            var numberForFind = 10;

            //ACT
            var result = _validation.ListContainsNumber(list, numberForFind);

            //ASSERT
            Assert.False(result);
        }

        [Fact]
        public void MustMultiplyTheElementsFor2()
        {
            //ARRANGE
            var list = new List<int> {5,7,8,9};
            var expectedResult = new List<int> {10, 14, 16, 18};
            
            //ACT
            var result = _validation.MultiplyNumbersofList(list, 4);

            //ASSERT
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MustReturn9TheMaxListValue()
        {
            //ARRANGE
            var list = new List<int> {5, -1, -8, 9};
            var expectedResult = 9;

            //ACT
            var result = _validation.ReturnHighestNumber(list, expectedResult);

            //ASSERT
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MustReturnNegative8TheMinimumListValue()
        {
            //ARRANGE
            var list = new List<int>{5, -1, -8, 9};
            
            //ACT
            var resultado = _validation.ReturnLowestNumber(list);

            //ASSERT
            Assert.Equal(-8, -8);
        }
    }
}