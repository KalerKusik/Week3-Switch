using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrollib, kas sisestatud täht on täis või kaashäälik
            //kui sisestatud täht on täishäälik - programm kuvab "täishäälik"
            //kui sisestatud täht on kaashäälik - programm kuvab "kaashäälik"

            Console.WriteLine("Sisesta Täht:");
            char UserCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (UserCharacter)
            {
                case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                    break;
                default:
                    Console.WriteLine("Kaashäälik");
                    break;
            }
            Console.WriteLine("Kena päeva!");
            }
        }
        }
                      