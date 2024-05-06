using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите сообщение для шифровки :");
            string message = Console.ReadLine();
            string encryptedMessage = EncryptMessage(message);
            Console.WriteLine($"Зашифрованное сообщение: {encryptedMessage}");

            Console.WriteLine("Введите сообщение для расшифровки :");
            string encryptedInput = Console.ReadLine();
            string decryptedMessage = DecryptMessage(encryptedInput);
            Console.WriteLine($"Расшифрованное сообщение: {decryptedMessage}");


        }

        static string EncryptMessage(string message)
        {
            string[] words = message.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }
            return string.Join(" ", words);
        }

        static string DecryptMessage(string EncryptMessage)
        {
            string[] words = EncryptMessage.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }
            return string.Join(" ", words);
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
