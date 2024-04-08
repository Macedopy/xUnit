using UnitTestController.Service;

namespace UnitTestTester;

public class ValidationStringTest
{
    private ValidationString _validation = new ValidationString();

    [Fact]
    public void MustReturn6LenghtOfWord()
    {
        //ARRANGE
        var text = "a";
        var expectedResult = 0;

        //ACT
        var result = _validation.ReturnTheLenght(text);

        //ASSERT
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void MustContainsTheWordTEST()
    {
        //ARRANGE
        var text = "This is aleatory text.";
        var expectedText = "text";

        //ACT
        var result = _validation.HasCharacteres(text, expectedText);

        //ASSERT
        Assert.False(true);
    }

    [Fact]
    public void TextMustContainsTheWordFinalFind()
    {
        //ARRANGE
        var text = "I want the text final";
        var expectedText = "final";
        //ACT
        var result = _validation.EndWith(expectedText, text);

        //ASSERT
        Assert.True(result);
    }
}