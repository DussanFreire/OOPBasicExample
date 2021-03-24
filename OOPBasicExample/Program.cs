using System;

namespace OOPBasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Falcon myFalcon = new Falcon();
            myFalcon.FlyAscending();
            myFalcon.MakeNoise();

            myFalcon.FlyAscending();
            myFalcon.MakeNoise();

            myFalcon.FlyDescending();
            myFalcon.MakeNoise();

            Bird myBird= new Falcon();
            IFly MyFlyer = new Falcon();
        }
    }
}
