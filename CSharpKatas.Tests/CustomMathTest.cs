using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using KatasCSharp;

namespace CSharpKatas.Tests
{
    
    public class CustomMathTest
    {
        [Fact]
        public void ShouldMultiply()
        {
            Assert.Equal(2, CustomMath.multiply(2, 1));
            Assert.Equal(8, CustomMath.multiply(2, 4));
        }
        
    }
}
