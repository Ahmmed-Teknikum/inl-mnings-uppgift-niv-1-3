using System;

namespace inlämningUppgift_._nivå1_._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            int tal= int.Parse(Console.ReadLine());
           

            Console.WriteLine("Skriv in ett annat heltal");
            int tal1= int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in ett annat heltal");
            int tal2= int.Parse(Console.ReadLine());
            

            Console.WriteLine("Skriv in ett annat heltal");
            int tal3= int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in ett annat heltal");
            int tal4= int.Parse(Console.ReadLine());

            int sum= tal+tal1+ tal2+ tal3+ tal4;
            Console.WriteLine("Summan blir "  +  sum);


        }
    }
}