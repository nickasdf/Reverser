namespace Reverser
{
    static class Program
    {
        static void Main()
        {
            string stringToReverse = "asd xcb dffh";

            StringReverser r = new StringReverser();


            Console.WriteLine(stringToReverse);

            Console.WriteLine(r.Reverse(stringToReverse));

            Console.WriteLine(r.ReverseSeparetly(stringToReverse));
            

            
        }
    }
} 