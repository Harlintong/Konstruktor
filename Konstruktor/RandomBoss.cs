using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktor
{
    class RandomBoss
    {
        Random Generator = new Random();

        public int hp;

        public RandomBoss()
        {
            hp = Generator.Next(50, 150);
        }
    }
}
