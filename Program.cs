using System;
using System.Collections.Generic;

namespace Ex3_Laborator6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevi[] elev = new Elevi[3];
            elev[0] = new Elevi("Popescu", "Razvan", new int[] { 5, 7, 9 });
            elev[1] = new Elevi("Ilie", "Andrei", new int[] { 10, 4, 8, 9 });
            elev[2] = new Elevi("Antonescu", "Ciprian", new int[] { 7, 9, 9 });

            Catalog unsprezeceD = new Catalog("XI-D", elev);

            unsprezeceD.Tipareste();

            int indexPremiant = unsprezeceD.GetPremiant();
            Console.WriteLine($"Elevul premiant este {elev[indexPremiant].GetNumePremiant()}");
        }
    }
}
