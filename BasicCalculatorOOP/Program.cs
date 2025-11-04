namespace BasicCalculatorOOP
{
    internal class Program // Entry point of the application
    {
        static void Main(string[] args)
        {
            // create new class instance(object)
            //of Calculator class
            Calculator calc = new Calculator();

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number;");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation(+,-,*,/): ");
            string op = Console.ReadLine();

            double result = 0;

                switch (op)
                {
                     case "+":
                    result = calc.Add(num1, num2);
                    break;
                    case "-":
                    result = calc.Substract(num1, num2);
                    break;
                     case "*":
                    result = calc.Multiply(num1, num2);
                    break;
                     case "/":
                    result = calc.Divide(num1, num2);
                    break;
                     default:
                    Console.WriteLine("Invalid operation.");
                    return;
                }
                    Console.WriteLine($"Result: {result}");





        }
    }
}
