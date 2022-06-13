using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using AssessmentTask;


namespace AssessmentTaskTests
{
    public class ClGameTests
    {


        [Theory]
        [InlineData(new int[] { 2, 7, 3, 11, 2, 2 }, 4.50)]
        [InlineData(new int[] { 18, 4, 6, 12, 19 }, 11.80)]
        [InlineData(new int[] { 5 }, 5)]
        [InlineData(new int[] { }, 0)]
        public void AverageTest(int[] input, double expected)
        {
            ClGame clGame = new ClGame();
            clGame.Results = input.ToList();
            var average = clGame.GetAverage();
            Assert.Equal(expected, average);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 3, 11, 2, 2 }, 27)]
        [InlineData(new int[] { 18, 4, 6, 12, 19 }, 59)]
        [InlineData(new int[] { 5 }, 5)]
        [InlineData(new int[] { }, 0)]
        public void TotalTest(int[] input, int expected)
        {
            ClGame clGame = new ClGame();
            clGame.Results = input.ToList();
            var total = clGame.GetTotal();
            Assert.Equal(expected, total);
        }

    }
}
