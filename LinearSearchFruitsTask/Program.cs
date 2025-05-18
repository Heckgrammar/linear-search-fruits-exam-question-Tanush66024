namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
            string word;
            bool found = false;
            Console.WriteLine("Enter the word you would like to find");
            word = Console.ReadLine();
            for (int i = 0;i < fruits.Length; i++ )
            {
                if (word == fruits[i])
                {
                    Console.WriteLine("true");
                    found = true;
                }
            }if (found == false)
            {
                Console.WriteLine("false");
            }
            
        }
    }
}
