using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace maks_lr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex1 = new Regex(@"^(a|a{6}|(a\s?)+)$");

            string path1 = @"D:\maks_lr4_text.txt";
            if (File.Exists(path1))
            {
                string[] input = File.ReadAllLines(path1);
                Console.WriteLine($"REGULAR EXPRESSION 1:\n{regex1}");
                for (int i = 0; i < input.Length; ++i)
                {
                    Console.WriteLine($"{input[i]}\t{regex1.IsMatch(input[i])}");
                }
                Console.WriteLine("\n");
            }
            Regex regex2 = new Regex(@"\w{5,}");

            string path2 = @"D:\maks_lr4_text2.txt";
            if (File.Exists(path2))
            {
                string[] input = File.ReadAllLines(path2);
                Console.WriteLine($"REGULAR EXPRESSION 2:\n{regex2}");
                for (int i = 0; i < input.Length; ++i)
                {
                    Console.WriteLine($"{input[i]}\t{regex2.IsMatch(input[i])}");
                }
                Console.WriteLine("\n");
            }
            Regex regex3 = new Regex(@"^[a-zA-Z]\w{5,50}@(mail|gmail|inbox|internet)\.(ru|com)$");

            string path3 = @"D:\maks_lr4_text3.txt";
            if (File.Exists(path3))
            {
                string[] input = File.ReadAllLines(path3);
                Console.WriteLine($"REGULAR EXPRESSION 3:\n{regex3}");
                for (int i = 0; i < input.Length; ++i)
                {
                    Console.WriteLine($"{input[i]}\t{regex3.IsMatch(input[i])}");
                }
                Console.WriteLine("\n");
            }
            //Regex regex4 = new Regex(@"^([а-яА-Я]{5,50})\s[а-яА-Я]{2,50}\s([а-яА-Я]{5,50}),\s([1-9])\sлет,\s(г\.)\s(Новосибирск|Москва|Санкт-Петербург|Екатеринбург|Омск|Томск|)$");
            string regex4 = @"^([а-яА-Я]{5,50})\s[а-яА-Я]{2,50}\s?([а-яА-Я]{5,50})?,\s([1-9]{1,2})\sлет,\s?(г\.)?\s(Новосибирск|Москва|Санкт-Петербург|Екатеринбург|Омск|Томск|)$";

            string path4 = @"D:\maks_lr4_text4.txt";
            if (File.Exists(path4))
            {
                string[] input = File.ReadAllLines(path4);
                Console.WriteLine($"REGULAR EXPRESSION 4:\n{regex4}");
                for (int i = 0; i < input.Length; ++i)
                {
                    Match match = Regex.Match(input[i], regex4);
                    if (match.Success)
                    {
                        string lastName = match.Groups[1].Value;
                        string age = match.Groups[3].Value;
                        string city = match.Groups[5].Value;

                        Console.WriteLine($"{lastName}\n{age}\n{city}");
                    }
                    else Console.WriteLine("пиздец");
                }
            }
            Console.ReadKey();
        }
    }
}
