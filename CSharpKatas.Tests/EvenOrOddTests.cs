using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatasCSharp;
using Xunit;

namespace CSharpKatas.Tests
{

    public class EvenOrOddTests
    {
        [Fact]
        public void IsItEven()
        {
            Assert.Equal("Even", EvenOrOdd.IsEvenOrOdd(2));
            Assert.Equal("Odd", EvenOrOdd.IsEvenOrOdd(1));
            Assert.Equal("Even", EvenOrOdd.IsEvenOrOdd(0));
            Assert.Equal("Odd", EvenOrOdd.IsEvenOrOdd(7));
            Assert.Equal("Odd", EvenOrOdd.IsEvenOrOdd(-1));

        }
    }
}
