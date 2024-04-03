// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// using System;

// class Program
// {
//     static void Main()
//     {
//         char[,] charArray = new char[,] { { 'H', 'e', 'l' }, { 'l', 'o', '!' } };
        
//         string str = "";
        
//         for (int i = 0; i < charArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < charArray.GetLength(1); j++)
//             {
//                 str += charArray[i, j];
//             }
//         }
        
//         Console.WriteLine("Созданная строка: " + str);
//     }
// }


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите строку с латинскими буквами в обоих регистрах:");
//         string inputString = Console.ReadLine();

//         string outputString = "";

//         foreach (char c in inputString)
//         {
//             if (char.IsUpper(c))
//             {
//                 outputString += char.ToLower(c);
//             }
//             else
//             {
//                 outputString += c;
//             }
//         }

//         Console.WriteLine("Строка с замененными заглавными буквами на строчные: " + outputString);
//     }
// }

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите строку для проверки на палиндром:");
//         string inputString = Console.ReadLine();

//         bool isPalindrome = CheckIfPalindrome(inputString);

//         if (isPalindrome)
//         {
//             Console.WriteLine("Введенная строка является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Введенная строка не является палиндромом.");
//         }
//     }

//     static bool CheckIfPalindrome(string str)
//     {
//         int left = 0;
//         int right = str.Length - 1;

//         while (left < right)
//         {
//             if (str[left] != str[right])
//             {
//                 return false;
//             }
//             left++;
//             right--;
//         }

//         return true;
//     }
// }

// Задача 4: Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите строку с словами, разделенными пробелами:");
//         string inputString = Console.ReadLine();

//         string reversedString = ReverseWords(inputString);

//         Console.WriteLine("Строка с словами в обратном порядке:");
//         Console.WriteLine(reversedString);
//     }

//     static string ReverseWords(string str)
//     {
//         string[] words = str.Split(' ');

//         Array.Reverse(words);

//         return string.Join(" ", words);
//     }
// }
