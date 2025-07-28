namespace assignment_c__advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int valueToCheck = 12;
            bool isInRange = Range.IsInRange(numbers, valueToCheck);
            Console.WriteLine($" Number {valueToCheck} in range? {isInRange}");
            Console.WriteLine($"Length of the array: {Range.Length(numbers)}");

        }
    }
}
