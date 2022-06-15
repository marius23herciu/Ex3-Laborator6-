using System;
using System.Collections.Generic;

namespace Ex3_Laborator6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Elev[] elev = new Elev[3];
            elev[0] = new Elev("Popescu", "Razvan", new int[] { 5, 7, 9 });
            elev[1] = new Elev("Ilie", "Andrei", new int[] { 10, 4, 8, 9 });
            elev[2] = new Elev("Antonescu", "Ciprian", new int[] { 7, 9, 9 });

            Catalog unsprezeceD = new Catalog("XI-D", elev);

            unsprezeceD.Tipareste();

            Elev elevPremiant = unsprezeceD.GetPremiantul();

            Console.WriteLine("Elevul premiant este:");
            elevPremiant.Tipareste();
        }
    }
}
