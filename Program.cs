namespace Lab_9a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the string array: ");
            int stringArraySize = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the integer array: ");
            int integerArraySize = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the double array: ");
            int doubleArraySize = int.Parse(Console.ReadLine());

            // Create the arrays based on the user input
            string[] stringArray = new string[stringArraySize];
            int[] integerArray = new int[integerArraySize];
            double[] doubleArray = new double[doubleArraySize];

            // Prompt the user to enter values for the string array
            Console.WriteLine("Enter values for the string array:");
            for (int i = 0; i < stringArraySize; i++)
            {
                Console.Write($"Enter value for element {i}: ");
                stringArray[i] = Console.ReadLine();
            }

            // Prompt the user to enter values for the integer array
            Console.WriteLine("Enter values for the integer array:");
            for (int i = 0; i < integerArraySize; i++)
            {
                Console.Write($"Enter value for element {i}: ");
                integerArray[i] = int.Parse(Console.ReadLine());
            }

            // Prompt the user to enter values for the double array
            Console.WriteLine("Enter values for the double array:");
            for (int i = 0; i < doubleArraySize; i++)
            {
                Console.Write($"Enter value for element {i}: ");
                doubleArray[i] = double.Parse(Console.ReadLine());
            }

            // Display the entered values for each array
            Console.WriteLine("Entered values for the string array:");
            foreach (string value in stringArray)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Entered values for the integer array:");
            foreach (int value in integerArray)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Entered values for the double array:");
            foreach (double value in doubleArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}