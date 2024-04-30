namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int a = 17;
            int b = 4;

            int sum = a + b;
            int minus = a - b;
            int multiply = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            AreaOfCircle();

            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // ouputs ? 16
        }

        public static double AreaOfCircle()
        {
            Console.WriteLine("Please enter the raidus of the circle to caluclate the area.");
            double radius = double.Parse(Console.ReadLine());
            double solve = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {solve}.");
            return solve;
        }


        
    }
}
