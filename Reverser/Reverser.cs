
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
            int objInList = Split(s).Count;
            int a = 0;

            foreach (var word in Split(s))
            {
                if (objInList - 1 == a)
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


        public List<string> Split(string s)
        {

            int length = s.Length;
            char[] tempChar = new char[s.Length];
            


            List<string> split = new List<string>();
            

            for (int i = 0; i < length; i++)
            {
                if (s[i] != ' ')
                {
                    tempChar[i] = s[i];

                  
                }
                else
                {
                    split.Add(new string(tempChar));
                    tempChar = new char[s.Length];
                                    
                }
                if (i == length - 1) 
                {
                    split.Add(new string(tempChar));
                    tempChar = new char[s.Length];

                }

            }


            return split;
        }
    }
}
