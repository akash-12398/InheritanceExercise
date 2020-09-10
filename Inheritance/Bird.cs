using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Wings = 4;
            Beak = 1;
            CanFly = true;
            DoMigrate = true;


        }

        public int Wings {get; set; }
        public int Beak { get; set; }
        public bool CanFly { get; set; }
        public bool DoMigrate { get; set; }


    }
}
