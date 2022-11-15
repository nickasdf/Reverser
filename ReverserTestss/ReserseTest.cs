using Reverser;

namespace ReverserTestss
{
    public class ReserseTest
    {
        private readonly StringReverser _stu = new();

        [Theory]
        [InlineData("a1bc    d~!ef     g1h", "c1ba    f~!ed     h1g")]
        
        public void It_should_reverse_all_separetly(string str, string expected)
        {
            Assert.Equal(expected, _stu.ReverserSeparetly(str));
        }

        [Theory]
        [InlineData("a1bc d~!ef g1h", "h1gf e~!dc b1a")]
        public void It_should_reverse_all(string str, string expected)
        {
            Assert.Equal(expected, _stu.ReverseWord(str));
        }


    
    }
}