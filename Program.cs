using System;

namespace Polymorphism
{    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Animal ani = new Animal();
            //ani.Feed(1);
            //ani.Feed("A");

            //Ase ac = new Ase();
            //ac.Increase();
            //ac.Increase("A" );
            //Console.WriteLine("Temperature : {0}", ac.Temperature);

            //AG1000 roket = new AG1000();
            //roket.SetLevel(1000);
            //Console.WriteLine("Rocket Level: {0}", roket.GetLevel());
            //roket.Launch();

            //Vehicle veh = new Vehicle();
            //veh.Send("Hello Worlds");
            //veh.Receive();

            //Message m = veh;

            //m.Receive();

            WaterCannon wc = new WaterCannon();
            Console.WriteLine("WC Open: {0}", wc.Open());
            Console.WriteLine("WC Close: {0}", wc.Close());
        }
    }

    class Ase : AirConditioner
    {
        public override void Increase()
        {
            temp += 3;
        }

        public void Increase(String str)
        {
            Console.WriteLine("Dih kok string kocak");
        }
    }

    class AirConditioner
    {
        public int temp = 23;
        public int Temperature { get { return temp; } }
        public AirConditioner() { temp = 1; }

        public virtual void Increase() { temp += 2;  }
    }

    class Animal
    {
        public void Feed(String str)
        {
            Console.WriteLine("Feed String!");
        }

        public void Feed(int str)
        {
            Console.WriteLine("Feed Integer!");
        }
    }
}
