namespace LiskovSubstitutionPrincipleApp.With_LiskovSubstitutionPrinciple.Scenario1
{
    using System;

    // Base class for all birds
    public abstract class Bird
    {
        public abstract void Move();
    }

    // Derived class for flying birds
    public class FlyingBird : Bird
    {
        public override void Move()
        {
            Fly();
        }

        public virtual void Fly()
        {
            Console.WriteLine("This bird is flying.");
        }
    }

    // Derived class for non-flying birds
    public class NonFlyingBird : Bird
    {
        public override void Move()
        {
            Walk();
        }

        public virtual void Walk()
        {
            Console.WriteLine("This bird is walking.");
        }
    }

    // Subclass for sparrow, a flying bird
    public class Sparrow : FlyingBird
    {
        public override void Fly()
        {
            Console.WriteLine("The sparrow is flying.");
        }
    }

    // Subclass for penguin, a non-flying bird
    public class Penguin : NonFlyingBird
    {
        public override void Walk()
        {
            Console.WriteLine("The penguin is waddling.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Now substitution works correctly
            Bird sparrow = new Sparrow();
            sparrow.Move();  // Output: "The sparrow is flying."

            Bird penguin = new Penguin();
            penguin.Move();  // Output: "The penguin is waddling."
        }
    }



}
