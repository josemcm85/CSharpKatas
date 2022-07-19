using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatasCSharp;
using Xunit;

namespace CSharpKatas.Tests
{
    public class GreetingTests
    {
        [Fact]
        public void GreetingShouldReturnHi()
        {
            //Arrange
            string name = "Jose";

            //Act
            string actual = Greeting.Greet(name);

            //Assert
            Assert.Equal("Hello, Jose how are you doing today?", actual);

        }
    }
}
