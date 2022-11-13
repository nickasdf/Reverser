using Reverser;

namespace ReverserTestss
{
    public class ReserseTest
    {
        private readonly StringReverser _stu = new();

        [Theory]
        [InlineData("asd", "dsa")]
        [InlineData("asd fba", "abf dsa")]
        public void It_should_reverse_all(string str, string expected)
        {

            Assert.Equal(expected, _stu.Reverse(str));
        }

        [Theory]
        [InlineData("asd fgh jkl", "dsa hgf lkj")]
        public void It_should_reverse_separate(string str, string expected)
        {
            string result = _stu.ReverseSeparetly(str);
            Assert.Equal(expected, result);
        }

      

    }
}