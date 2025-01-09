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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            
            var birdOne = new Bird();
            birdOne.Name = "Hawk";
            birdOne.Age = 2;
            birdOne.Diet = "Carnivore";
            birdOne.IsNocturnal = "false";
            birdOne.BeakType = "hooked";
            birdOne.CanFly = true;
            birdOne.FeatherColor = "brown";
            birdOne.Wingspan = 8;
            
            Console.WriteLine($"Name: {birdOne.Name}\n,Age: {birdOne.Age}\nDiet: {birdOne.Diet}\nNocturnal: {birdOne.IsNocturnal}\nBeak: {birdOne.BeakType}\nFlight: {birdOne.CanFly}\nFeather: {birdOne.FeatherColor}\nWingspan: {birdOne.Wingspan}");
            Console.WriteLine();
            
            var reptileOne = new Reptile()
            {
                Name = "Python",
                Age = 1,
                Diet = "small rodents",
                IsNocturnal = "true",
                ForkTongue = true,
                HasShell = false,
                IsVenomous = true,
                ScaleColor = "yellow",
            }
            ;
            
            Console.WriteLine($"Name: {reptileOne.Name}\nAge: {reptileOne.Age}\nDiet: {reptileOne.Diet}\nNocturnal: {reptileOne.IsNocturnal}\nShell: {reptileOne.HasShell}\nVenomous: {reptileOne.IsVenomous}\nScaleColor: {reptileOne.ScaleColor}" );
            Console.WriteLine();

        }
    }
}
