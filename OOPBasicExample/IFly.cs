using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasicExample
{
    public interface IFly
    {
        int MaxHeightFlying { get; set; }
        int CurrentHeight{ get; set; }
        void FlyAscending();
        void FlyDescending();
    }
}
