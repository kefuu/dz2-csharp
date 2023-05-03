using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_csharp
{
    internal class task3
    {
        public static void func_task3(string[] args)
        {
            {
                Console.WriteLine("Enter a string to encrypt:");
                string input = Console.ReadLine();

                string encrypted = CaesarCipherEncrypt(input, 3);
                Console.WriteLine("Encrypted string: " + encrypted);

                string decrypted = CaesarCipherDecrypt(encrypted, 3); 
                Console.WriteLine("Decrypted string: " + decrypted);
            }

            static string CaesarCipherEncrypt(string input, int shift)
            {
                string encrypted = "";
                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        char shifted = (char)(((c + shift - 'A') % 26) + 'A'); 
                        encrypted += shifted;
                    }
                    else
                    {
                        encrypted += c;
                    }
                }
                return encrypted;
            }

            static string CaesarCipherDecrypt(string input, int shift)
            {
                string decrypted = "";
                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        char shifted = (char)(((c - shift - 'A' + 26) % 26) + 'A');
                        decrypted += shifted;
                    }
                    else
                    {
                        decrypted += c; 
                    }
                }
                return decrypted;
            }
        }
        }
}
