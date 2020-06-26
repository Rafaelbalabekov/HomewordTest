using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
   public class GenerateWords
    {

            Random rnd = new Random();
            public string GetRandomWord(int Length)
            {
                string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz";
                StringBuilder sb = new StringBuilder(Length - 1);
                int Position = 0;

                for (int i = 0; i < Length; i++)
                {
                    Position = rnd.Next(0, Alphabet.Length - 1);
                    sb.Append(Alphabet[Position]);
                }
                return sb.ToString();
            }

        }
    }

