using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using KatasCSharp;

namespace CSharpKatas.Tests
{
    public class FriendsTests
    {   
        [Fact]
        public void Test()
        {
            
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            Assert.Equal(expected, Friends.FriendOrFoe(names));
        }
    }
}
