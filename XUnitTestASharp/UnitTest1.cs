using System;
using Xunit;

namespace ASharpParcer
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            char[] arr = new char[] { 'h', 'e', 'l', 'l', 'o' };
            Assert.Equal("hello", HelpMethods.CharArrToString(arr));
        }
    }
}
