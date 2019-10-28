using System;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            string userInput;
            Console.WriteLine("Please write a line and I will check if that is a palindrome or not");
            userInput = Console.ReadLine().ToUpper();
            char[] LettersInOrder = userInput.ToCharArray();
            char[] LettersReversed = userInput.ToCharArray();
            Array.Reverse(LettersReversed);
            CheckPalindrome(LettersInOrder, LettersReversed, userInput);
            goto Start;
        }

        public static void CheckPalindrome(char[] correctArray, char[]reversedArray, string input)
        {
            int counter = 0;
            for (int i = 0; i <= correctArray.Length-1; i++)
            {
                if (correctArray[i] == reversedArray[i])
                {
                    counter++;
                    
                }
                else { }
            }
            if (counter != correctArray.Length)
            {
                Console.WriteLine($"Your input {input} is not a palindrome");
            }
            else
            {
                Console.WriteLine($"Your input {input} is a palindrome");
            }
        } 
    }
}
