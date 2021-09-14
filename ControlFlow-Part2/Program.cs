using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada PIN-koodi
            //programm võrdleb sisustatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234, programm kuvad konsool "Tere tulemast!"
            //Kui sisustatud PIN on vale, programm kuvab konsoolis "Vale PIN. Proovi uuesti"

            Console.WriteLine("Palun sisesta PIN:");
            int UserPIN = Convert.ToInt32(Console.ReadLine());

            if (UserPIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }    
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }
         


        }
    }
}
