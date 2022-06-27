using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatasCSharp;
using Xunit;

namespace CSharpKatas.Tests
{
    public class ReverseWordsTests
    {
        [Fact]
        public void TestReverseWord()
        {

            string word = "This is an example!";
            Assert.Equal("sihT si na !elpmaxe",ReverseWords.ReverseWord(word));
            
        }


    }
}
