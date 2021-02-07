using LibreriaTelefono;
using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserisci qui sotto il numero di telefono: ");
            string numero =Console.ReadLine();
            Sim simutente = new Sim(numero, 10);
            Console.WriteLine($"Numero seriale : {simutente.Seriale}");
            Console.ReadLine();
        }
    }
}
