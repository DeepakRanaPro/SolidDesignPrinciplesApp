namespace LiskovSubstitutionPrincipleApp.With_LiskovSubstitutionPrinciple.Scenario2
{
    public abstract class Bird
    {
        public abstract void Move();
    }

    public class FlyingBird : Bird
    {
        public override void Move()
        {
            Console.WriteLine("This bird can fly.");
        }
    }

    public class NonFlyingBird : Bird
    {
        public override void Move()
        {
            Console.WriteLine("This bird runs.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Bird sparrow = new FlyingBird();
            Bird ostrich = new NonFlyingBird();

            MakeBirdMove(sparrow);  // Output: This bird can fly.
            MakeBirdMove(ostrich);  // Output: This bird runs.
        }

        public static void MakeBirdMove(Bird bird)
        {
            bird.Move();
        }
    }

}
