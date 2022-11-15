namespace Reverser
{
    static class Program
    {
        static void Main()
        {
            string stringToReverse = "a1bc d~!ef g1h";


            StringReverser r = new StringReverser();


            Console.WriteLine(r.ReverseWord(stringToReverse));
        }
    }
} 