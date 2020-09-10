using System;
namespace Inheritance
{
    public class Reptile
    {
        public Reptile()
        {
            Teeth = 6;
            Dangerous = true;
            UsedForPurses = true;
            HaveTail = false;

        }

        public int Teeth { get; set; }
        public bool Dangerous { get; set; }
        public bool UsedForPurses { get; set; }
        public bool HaveTail { get; set; }

    }
}
