namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            var additionalResult = calculator.Additional(5, 7);
            Console.WriteLine(additionalResult);

            var subtractionResult = calculator.Subtraction(2, 8);
            Console.WriteLine(subtractionResult);

            var multiplicationResult = calculator.Multiplication(6, 3);
            Console.WriteLine(multiplicationResult);

            var divisionResult = calculator.Division(6, 3);
            Console.WriteLine(divisionResult);

        }
    }
}
