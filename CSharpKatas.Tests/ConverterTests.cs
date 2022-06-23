using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatasCSharp;
using Xunit;

namespace CSharpKatas.Tests
{
    public class ConverterTests
    {
        [Fact]
        public void test()
        {
            Converter converter = new Converter();
            Assert.Equal("UUUU", converter.dnaToRna("TTTT"));
        }
    }
}
