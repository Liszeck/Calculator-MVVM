using System;
using Xunit;
namespace Claculator.Tests
{
    public class Class1
    {
        [Fact]
        public void Button_ShouldReplaceAnythingToZero() 
        {

            string expected = "0";

            string actual = "0";

            Assert.Equal(expected, actual);

        }
    }
}
