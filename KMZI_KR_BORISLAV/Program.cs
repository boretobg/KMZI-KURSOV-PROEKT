using System;
using System.Linq;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password count: ");
            int passwordCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter password lenght: ");
            int passwordLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < passwordCount; i++)
            {
                string password = GeneratePassword(passwordLength);
                Console.WriteLine($"Password {i + 1}: {password}");
            }

        }

        static string GeneratePassword(int length)
        {
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string specialChars = "!@#$%^&*()-_=+[]{}\\|;:'\",.<>/?";

            string allChars = uppercase + lowercase + numbers + specialChars;

            Random random = new Random();
            string password = new string(Enumerable.Repeat(allChars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return password;
        }
    }
}