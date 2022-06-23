using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using KatasCSharp;

namespace CSharpKatas.Tests
{
    public class ClassMatesTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3 }, 5)]
        [InlineData(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75)]
        [InlineData(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69)]
        public void FixedTest(int[] arr, int num)
        {
            Assert.True(Classmates.BetterThanAverage(arr, num));
        }
    }
}
