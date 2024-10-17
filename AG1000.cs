using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class AG1000 : Rocket
    {
        public int level = 0;
        public void SetLevel(int l)
        {
            level = l;
        }

        public int GetLevel()
        {
            return level;
        }
    }

    abstract class Rocket
    {
        public void Launch()
        {
            Console.WriteLine("Rocket Launch!!!");
        }
    }
}
