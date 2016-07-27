using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace WebAppCoreUnitTests
{
    public class Tests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void UsefulTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void MoreTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void AnotherTest()
        {
            Assert.Equal(5, Add(2, 3));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
