using System;

namespace AD2_Test2_Serge_Fabre
{
    class Program
    {
        static void Main(string[] args)
        {
            Ster Zon = new Ster("Zon", SterType.GeleDwerg);
            Planeet Aarde = new Planeet("", 12.756);
            Planeet Aarde2 = new Planeet("Aarde", 0);
            Planeet Aarde3 = new Planeet("Aarde", 12.756);
            Planeet Mercurius = new Planeet("Mercurius", 4.880);
            Planeet Jupiter = new Planeet("Jupiter", 142.984);
            Zon.Planeten.Add(Aarde3);
            Zon.Planeten.Add(Mercurius);
            Zon.Planeten.Add(Jupiter);

            Console.WriteLine($"De ster {Zon.Naam} heeft {Zon.Planeten.Count} planeten:");
            foreach (var item in Zon.Planeten)
            {
                Console.WriteLine($" {item.Naam}: met een diameter van {item.Diameter}.");
            }

            Console.WriteLine();
            Console.WriteLine($"Van Aarde en Mercurius is {Planeet.GrootstePlaneet(Aarde3, Mercurius)} de grootste planeet.");
            Console.WriteLine();
            Console.WriteLine($"Van Aarde en Jupiter is {Planeet.GrootstePlaneet(Aarde3, Jupiter)} de grootste planeet.");
            Console.WriteLine();
            Console.WriteLine(Zon.ZoekGrootstePlaneet());


            Console.ReadKey();

        }
    }
}
