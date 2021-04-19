using System;

namespace Assignement4
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignement4();
        }

        public static void Assignement4()
        {
            Console.WriteLine("Please write a word:");
            var input = Console.ReadLine();

            bool isPalindrom = false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    if (input[i] == input[j])
                    {
                        isPalindrom = true;
                        i++;
                    }
                    else
                    {
                        isPalindrom = false;
                        break;
                    }
                }
                break;
            }

            Console.WriteLine($"Cuvantul introdus este un palindrom: {isPalindrom}");
        }

    }
}
