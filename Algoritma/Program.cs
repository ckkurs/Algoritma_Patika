using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime ve çıkarmak istediğin karakter indeksini gir (Arada virgül olmalıdır):");
            string a = Console.ReadLine();

            string[] input = a.Split(",");
            string word = input[0];
            int number = Convert.ToInt32(input[1]);
            string newWord = word.Remove(number, 1);

            Console.WriteLine(newWord);
        }
    }
}
