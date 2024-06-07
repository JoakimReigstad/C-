using System;
using System.Collections.Generic;

namespace RandomHobbyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var hobbies = new List<string> { "Lese bøker", "Spille fotball", "Male", "Lage mat", "Se på filmer" };

           
            Console.Write("Skriv inn ditt navn: ");
            var name = Console.ReadLine();

     
            var randomHobby = HobbySelector.DrawRandomHobby(hobbies);

            
            Console.WriteLine($"Hei {name}, din tilfeldig valgte hobby er: {randomHobby}");
        }
    }
}
