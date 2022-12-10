namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            ReverseWord.Reverse(Console.ReadLine());
        }
    }
}