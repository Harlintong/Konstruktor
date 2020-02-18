using System;

namespace Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Baby baby = new Baby();
            Boss boss = new Boss();
            RandomBoss randomBoss = new RandomBoss();

            Console.WriteLine("Baby said: " + baby.Scream);
            Console.WriteLine("Boss hp: " + boss.hp);
            Console.WriteLine("RandomBoss: " + randomBoss.hp);

            Console.ReadLine();
        }
    }
}
