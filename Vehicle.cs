using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Vehicle : Message
    {
        String msg;
        public void Send(String s)
        {
            msg = s;
        }

        public void Receive()
        {
            Console.WriteLine(msg);
        }
    }

    abstract class Pump : Button
    {
        public String series;

        public Boolean Open()
        {
            return true;
        }

        public Boolean Close()
        {
            return false;
        }
    }

    interface Button
    {
        Boolean Open();
        Boolean Close();
    }

    class WaterCannon : Pump
    {
    }

    interface Message
    {
        void Send(string s);
        void Receive();
    }
}
