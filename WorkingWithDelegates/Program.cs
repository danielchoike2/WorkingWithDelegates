namespace Assignment8ex2
{
    public delegate void GetSmallerDelegate(double num1, double num2);
    public class MathSolutions
    {
        //public double GetSum(double x, double y)
        //{
            //return x + y;
       // }
        //public double GetProduct(double a, double b)
        //{
            //return a * b;
       // }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Func<double, double, double> addResult = delegate (double x, double y) { return x + y; };
            Console.Write("The result is: ");
            Console.Write(addResult(num1, num2));
            Console.WriteLine("");
            Action<double, double> multResult = delegate (double x, double y) { Console.WriteLine($"The result is {x * y}"); };
            multResult(num1, num2);
            // Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            GetSmallerDelegate smallerDelegate = new GetSmallerDelegate(answer.GetSmaller);
            smallerDelegate(num1,num2);
            
            

        }
    }
}
