using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("anna", true)]
        [InlineData("mom", true)]
        [InlineData("RADAR", true)]
        [InlineData("madam", true)]
        [InlineData("Anna", true)]
        [InlineData("Refer", true)]
        [InlineData("racecar", true)]
        [InlineData("donald", false)]
        [InlineData("tomorrow", false)]

        public void IsAPalindromeTest(string text, bool expected)
        {
            // Arrange
            var wordSmith = new WordSmith();

            // Act
            var actual = wordSmith.IsAPalindrome(text);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
