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

        [Theory]
        [InlineData("asd asd")]
        public void It_should_split_string_in_list(String str)
        {
            List<string> list = _stu.Split(str);
            string result1 = list[0];
            string result2 = list[1];


            Assert.Equal(2, list.Count);

            Assert.Equal(list[0] ,result1);
            Assert.Equal(list[1], result2);


        }

    }
}