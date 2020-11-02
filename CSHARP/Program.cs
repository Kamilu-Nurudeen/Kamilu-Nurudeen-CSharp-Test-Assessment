using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_QUESTION1_TO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1: Write a program in C# Sharp to display the characters and frequency of character from giving string.
            Console.WriteLine("QUESTION 1");
            Console.WriteLine("Write a program in C# Sharp to display the characters and frequency of character from giving string.");
            Console.WriteLine("Enter a word");
            string wordInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(wordInput))
            {
                Console.WriteLine("Your Input is empty. Input words from the English alphabet");
            }
            //Convert wordInput to lower to avoid the compiler from noting a capital letter and small letter character as differnt characters.
            string wordInputInLowerCase = wordInput.ToLower();
            //Group by character to enable effective reading by compiler.
            var list = wordInputInLowerCase.GroupBy(a => a).ToList();
            Console.WriteLine("The frequency of the characters are :");
            foreach ( var i in list)
            {
                Console.WriteLine($"Character {i.Key}: {i.Count()} times");
            }
            Console.ReadKey();



            //Question 2: Write a program in C# Sharp to display the list of items in the array according to the length of the string then by name in ascending order.
            Console.WriteLine("\n\nQUESTION 2");
            Console.WriteLine("Write a program in C# Sharp to display the list of items in the array according to the length of the string then by name in ascending order.\n");
            string[] city = {"ZURICH", "NAIROBI", "CALIFORNIA", "ABU DHABI", "ROME", "PARIS", "LONDON", "AMSTERDAM", "NEW DELHI"};
            //Convert the array to list
            List<string> cityList = city.OfType<string>().ToList();
            //Order the list according to the length of the string then by name in ascending order 
            var cityRearranged = cityList.OrderBy (b => b.Length).ThenBy (c => c.First());
            //Output each city name in the rearranged list
            foreach ( var d in cityRearranged)
            {
                Console.WriteLine($"{d}");
            }
            Console.ReadKey();

            //Question 3: Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
            Console.WriteLine("\n\nQUESTION 3");
            Console.WriteLine("Write a C# Sharp program to exchange the first and last characters in a given string and return the new string");
            Console.WriteLine("Input a string value: ");
            string stringInput = Console.ReadLine();
            //If input value is a character, output the same character back
            if (stringInput.Length == 1)
            {
                Console.WriteLine($"New String is: {stringInput}");
            }
            else
            {
                char firstletter = stringInput.First();
                char lastletter = stringInput.Last();
                //Middle Letters is gotten using substring i.e letter after the first character up to the penultimate character in the string
                string middleLetters = stringInput.Substring(1, (stringInput.Length - 2));
                //Output result by joining the letters in the order below
                string result = $"{lastletter}{middleLetters}{firstletter}";
                Console.WriteLine($"New string is: {result}");
            }
            Console.ReadKey();


            //Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
            Console.WriteLine("\n\nQUESTION 4");
            Console.WriteLine("Write a C# Sharp program to check whether an alphabet is a vowel or consonant.");
            char[] consonants = {'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z'};
            char[] vowels = {'A', 'E', 'I', 'O', 'U'};
            //Input english alphabet
            Console.WriteLine("INPUT ANY ENGLISH ALPHABET: ");
            //convert string input to char the char to uppercase
            char CharInput = Convert.ToChar(Console.ReadLine());
            char CharInputToUpperCase = Char.ToUpper(CharInput);
            //if the input is contained in the variable consonant, give output that the alphabet is a consonant.
            if (consonants.Contains(CharInputToUpperCase))
            {
                Console.WriteLine($"The alphabet {CharInputToUpperCase} is a consonant");
            }
            //if the input is contained in the variable vowel, give output that the alphabet is a vowel.
            else if (vowels.Contains(CharInputToUpperCase))
            {
                Console.WriteLine($"The alphabet {CharInputToUpperCase} is a vowel");
            }
            Console.ReadKey();








        }
    }
}
