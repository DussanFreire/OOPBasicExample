using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasicExample
{
    class Falcon: Bird, IFly
    {
        public int MaxHeightFlying { get; set ; }
        public int CurrentHeight { get; set; }
        public Falcon()
        {
            SpeciesName = "Falcon";
            MaxHeightFlying = 100;
            CurrentHeight = 0;
        }
    
        public void FlyAscending()
        {
            CurrentHeight = CurrentHeight + 10 <= MaxHeightFlying ? CurrentHeight + 10 : MaxHeightFlying;
        }

        public void FlyDescending()
        {
            CurrentHeight = CurrentHeight >= 10 ? CurrentHeight - 10 : 0;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"I'm a {SpeciesName}, my current height is {CurrentHeight}[m]");
        }
    }
}
