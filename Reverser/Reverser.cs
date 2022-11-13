
using System; 

namespace Reverser
{
    public class StringReverser
    {
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            char[] result = new char[charArray.Length];
            int length = charArray.Length - 1;

            for (int i = 0; i <= length; i++)
            {
                result[length - i] = charArray[i];
            }
            return new string(result);
        }

        public string ReverseSeparetly(string s)
        {
            string strrev = "";
            string[] mylist = s.Split(' '); ;

            int a = 0;
            foreach (var word in mylist)
            {
                if (mylist.Length - 1 == a)
                {
                    strrev += Reverse(word);
                }
                else
                {
                    strrev += Reverse(word) + " ";
                }
                a++;
            }
            return strrev;
        }
    }
}
