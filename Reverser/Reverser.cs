using System;

namespace Reverser
{
    public class StringReverser
    {

        public string ReverserSeparetly(string str)
        {
            string[] strArr = str.Split(' ');
            string result = "";
            int length = strArr.Length;
            
            for (int i = 0; i < length; i++)
            {
                if (i == length-1)
                {
                    result += ReverseWord(strArr[i]);

                }
                else 
                {
                    result += ReverseWord(strArr[i]) + " ";
                }
            }

            return result;
        }


        public string ReverseWord(string str)
        {

            int digitsAmount = 0;
            int length = str.Length;

            char[] sample = str.ToCharArray();
            char[] onlyLetters;

            char[] charResult = new char[length];
            string strResult;

            for (int i = 0; i < length; i++)
            {
                if (!(Char.IsLetter(sample[i])))
                {
                    charResult[i] = sample[i];
                    digitsAmount++;
                }

            }

            int j = 0;
            onlyLetters = new char[length - digitsAmount];
            for (int i = 0; i < length; i++)
            {
                if (Char.IsLetter(sample[i]))
                {
                    onlyLetters[j] = sample[i];
                    j++;
                }
            }

            int b = onlyLetters.Length - 1;
            for (int i = 0; i < length; i++)
            {
                if (!(Char.IsLetter(sample[i])))
                {
                }
                else
                {
                    charResult[i] = onlyLetters[b];
                    b--;
                }
            }
            strResult = new string(charResult);

            return strResult;
        }
    }
}
