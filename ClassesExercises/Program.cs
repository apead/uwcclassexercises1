namespace ClassesExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 4, 6, 6 };
            
            bool isOddNumber = OddNumbers.CheckOddNumbers(numbers);

            if (isOddNumber)
            {
                Console.WriteLine("The array contains an odd number");
            }
            else
            {
                Console.WriteLine("The array does not contain an odd number");

            }

            string letters = "Today is Tuesday";

            string removedVowelsString = Vowels.RemoveAllTheVowels(letters);
            Vowels.
            Console.WriteLine(removedVowelsString);

        }
    }
}
