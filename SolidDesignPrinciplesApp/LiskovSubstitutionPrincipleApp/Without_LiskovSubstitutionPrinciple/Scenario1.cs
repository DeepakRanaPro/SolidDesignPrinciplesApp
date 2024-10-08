namespace LiskovSubstitutionPrincipleApp.Without_LiskovSubstitutionPrinciple
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("This bird can fly.");
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }

    public class Penguin : Bird
    {
        // Penguin cannot fly, so overriding Fly method with wrong behavior
        public override void Fly()
        {
            throw new NotSupportedException("Penguins can't fly.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Bird myBird = new Bird();
            myBird.Fly(); // Works fine

            Bird myPenguin = new Penguin();
            myPenguin.Fly(); // Violates LSP, throws an exception
        } 
    }


}
