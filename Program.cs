// As an avid animal lover, you have started your very own collection of creatures in your home. You can use the code from the lesson as a starting point to have interfaces for walking and swimming animals, but you want to have several other kinds in your collection.

// This is the list of animals you want to own and care for.

// Parakeets
// Earthworms
// Terrapins
// Timber Rattlesnake
// Mice
// Ants
// Finches
// Betta Fish
// Copperhead snake
// Gerbils

// Each month, you clean out all of the habitats in a single day for efficiency. On that day, all animals need to be put into temporary containers. Each container will hold animals of similar similar, but different, types.

// Animals that dig and live in the ground
// Animals that move about on the ground
// Animals that swim in water
// Animals that fly above the ground

// Before you write any classes for the above animals, determine the common properties and behaviors that some of them share and define interfaces first.
// Once you believe you have a good set of interfaces, then start creating your specific animal classes and have them implement the appropriate interface.
// Then define classes to represent the containers that will hold various animals. Each container class should have a single property - a list to hold animal instances.
// Lastly, in Main() create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.

using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{

    // Interfaces
    public interface IDigger
    {
        string Name {get; set;}
        void dig();
    }
    public interface IWalker
    {
        string Name {get; set;}
        void walk();
        void run();
    }
    public interface ISwimmer
    {
        string Name {get; set;}
        void swim();
        int MaxDepth {get;}
    }
    public interface IFlier
    {
        string Name {get; set;}
        void fly();
        void land();
    }

    // Animals
    public class Parakeet : IFlier
    {
        public string Name {get; set;}
        public Parakeet(string name) {
            Name = name;
        }
        public void fly()
        {
            Console.WriteLine("The parakeet is flying");
        }
        public void land()
        {
            Console.WriteLine("The parakeet has landed");
        }
    }
    public class Earthworm : IDigger
    {
        public string Name {get; set;}
        public Earthworm(string name) {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The earthworm is digging");
        }
    }
    public class Terrapin : IWalker, ISwimmer
    {
        public string Name {get; set;}
        public Terrapin(string name) {
            Name = name;
        }
        public void walk()
        {
            Console.WriteLine("The terrapin is walking");
        }
        public void run()
        {
            Console.WriteLine("The terrapin is running");
        }
        public void swim()
        {
            Console.WriteLine("The terrapin is swimming");
        }
        public int MaxDepth {get;} = 5;
    }
    public class TimberRattlesnake : IWalker
    {
        public string Name {get; set;}
        public TimberRattlesnake(string name) {
            Name = name;
        }
        public void walk()
        {
            Console.WriteLine("The timber rattlesnake is slithering slowly");
        }
        public void run()
        {
            Console.WriteLine("The timber rattlesnake is slithering quickly");
        }
    }
    public class Mouse : IDigger, IWalker
    {
        public string Name {get; set;}
        public Mouse(string name) {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The mouse is burrowing");
        }
        public void walk()
        {
            Console.WriteLine("The mouse is walking");
        }
        public void run()
        {
            Console.WriteLine("The mouse is running");
        }
    }
    public class Ant : IDigger, IWalker
    {
        public string Name {get; set;}
        public Ant(string name) {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The ant is tunneling");
        }
        public void walk()
        {
            Console.WriteLine("The ant is walking");
        }
        public void run()
        {
            Console.WriteLine("The ant is walking faster");
        }
    }
    public class Finch : IFlier, IWalker
    {
        public string Name {get; set;}
        public Finch(string name) {
            Name = name;
        }
        public void fly()
        {
            Console.WriteLine("The finch is flying");
        }
        public void land()
        {
            Console.WriteLine("The finch has landed");
        }
        public void walk()
        {
            Console.WriteLine("The finch is hopping slowly");
        }
        public void run()
        {
            Console.WriteLine("The finch is hopping quickly");
        }
    }
    public class Betta : ISwimmer
    {
        public string Name {get; set;}
        public Betta(string name) {
            Name = name;
        }
        public void swim()
        {
            Console.WriteLine("The betta is swimming");
        }
        public int MaxDepth {get;} = 10;
    }
    public class Copperhead : IWalker
    {
        public string Name {get; set;}
        public Copperhead(string name) {
            Name = name;
        }
        public void walk()
        {
            Console.WriteLine("The copperhead is slithering slowly");
        }
        public void run()
        {
            Console.WriteLine("The copperhead is slithering quickly");
        }
    }
    public class Gerbil : IDigger, IWalker
    {
        public string Name {get; set;}
        public Gerbil(string name) {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The gerbil is burrowing");
        }
        public void walk()
        {
            Console.WriteLine("The gerbil is walking");
        }
        public void run()
        {
            Console.WriteLine("The gerbil is running");
        }
    }

    // Containers
    public class DiggerContainer
    {
        public List<IDigger> ContainedAnimals = new List<IDigger>();
    }
    public class WalkerContainer
    {
        public List<IWalker> ContainedAnimals = new List<IWalker>();
    }
    public class SwimmerContainer
    {
        public List<ISwimmer> ContainedAnimals = new List<ISwimmer>();
    }
    public class FlierContainer
    {
        public List<IFlier> ContainedAnimals = new List<IFlier>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create one of each container
            DiggerContainer dirtBox = new DiggerContainer();
            WalkerContainer fencedArea = new WalkerContainer();
            SwimmerContainer aquarium = new SwimmerContainer();
            FlierContainer aviary = new FlierContainer();

            // Create one of each animal, add to appropriate container
            aviary.ContainedAnimals.Add(new Parakeet("Simon the Parakeet"));

            dirtBox.ContainedAnimals.Add(new Earthworm("Jorah the Earthworm"));

            aquarium.ContainedAnimals.Add(new Terrapin("Calamy the Terrapin"));

            fencedArea.ContainedAnimals.Add(new TimberRattlesnake("Broderick the Timber Rattlesnake"));

            dirtBox.ContainedAnimals.Add(new Mouse("Sawyer the Mouse"));

            dirtBox.ContainedAnimals.Add(new Ant("Finn the Ant"));

            aviary.ContainedAnimals.Add(new Finch("Odin the Finch"));

            aquarium.ContainedAnimals.Add(new Betta("Thor the Betta"));

            fencedArea.ContainedAnimals.Add(new Copperhead("Martin the Copperhead"));

            dirtBox.ContainedAnimals.Add(new Gerbil("Gertie the Gerbil"));

            Console.WriteLine("Dirt Box contains:");
            dirtBox.ContainedAnimals.ForEach(animal => Console.WriteLine($" - {animal.Name}"));
            Console.WriteLine("Fenced Area contains:");
            fencedArea.ContainedAnimals.ForEach(animal => Console.WriteLine($" - {animal.Name}"));
            Console.WriteLine("Aquarium contains:");
            aquarium.ContainedAnimals.ForEach(animal => Console.WriteLine($" - {animal.Name}"));
            Console.WriteLine("Aviary contains:");
            aviary.ContainedAnimals.ForEach(animal => Console.WriteLine($" - {animal.Name}"));
        }
    }
}
