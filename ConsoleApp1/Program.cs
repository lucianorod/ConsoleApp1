using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // O Using aqui serve pra liberar o recurso após a utilização
            // Automaticamente chama o método Dispose do recurso

            // MemnorySharp não suporta aplicações 64bits
            using (var m = new MemorySharp(ApplicationFinder.FromProcessName("Skype").FirstOrDefault()))
            {
                Console.WriteLine("Inside using statement");
            }
            

            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
