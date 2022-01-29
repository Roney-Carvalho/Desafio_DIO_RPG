using System;
using DioGFTDesafio.Entities;

namespace DioGFTDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior w1 = new Warrior("Kratus", 30, 95, "Warrior");
            Mage m1 = new Mage("Gathrena", 62, 41, "Mage");
            Archer a1 = new Archer("Greenleaf", 25, 70, "Archer");

            System.Console.WriteLine(w1.Present());
            System.Console.WriteLine(m1.Present());
            System.Console.WriteLine(a1.Present());

            System.Console.WriteLine(w1.Attack());
            System.Console.WriteLine(m1.Attack());
            System.Console.WriteLine(a1.Attack());
        }
    }
}