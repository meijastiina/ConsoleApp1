using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            do
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ohjelman suoritus menee tällä rivillä.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occured ( { ex.Message } ).");
                }
                finally
                {
                    Console.WriteLine("Tämä tulostetaan aina.");
                }
            } while ();
        }
    }
}
