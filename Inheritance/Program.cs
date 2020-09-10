using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var mybird = new Bird();
            mybird.Wings = 4;
            mybird.Beak = 1;
            mybird.CanFly = true;
            mybird.DoMigrate = true;

            var mycrocodile = new Reptile()
            {
                Teeth = 6,
                Dangerous = true,
                UsedForPurses = true,
                HaveTail = false,
             };


            Console.WriteLine($"mybird has {mybird.Wings}Wings");
            Console.WriteLine($"mycrocodile {mycrocodile.Teeth}Teeth");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
