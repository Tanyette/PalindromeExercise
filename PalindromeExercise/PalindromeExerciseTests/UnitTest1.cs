using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {



        [Theory]
        [InlineData("civic", true)]
        [InlineData("deleveled", true)]
        [InlineData("devoved", true)]
        [InlineData("Hannah", true)]
        [InlineData("deified", true)]
        [InlineData("racecar", true)]
        public void PalindromeTester(string word, bool expected)
        {

            // Arrange- prepare the code i need
            //          in order to call the method.
            var wordSmith = new WordSmith();

            // Act
            var actual = wordSmith.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);











        }





    }
}
