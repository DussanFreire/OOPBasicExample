using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasicExample
{
    abstract class Bird 
    {
        protected string SpeciesName { get; set; }
        public abstract void MakeNoise();
    }
}
