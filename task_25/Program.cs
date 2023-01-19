internal class Program
{
    private static void Main(string[] args)
    {
        // // SЗадача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        // 3, 5 -> 243 (3⁵)
        // 2, 4 -> 16
        Console.Clear();
        Console.Write("Введите число А: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число B, которое будет являться степенью числа А: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        int GetResult(int numberA, int numberB)
        {
            int result = numberA;
            for (int i=1; i<numberB; i++)
            {
                result = result * numberA;
            }
            return result;
        }
        int result = GetResult(numberA, numberB);
        Console.WriteLine(result);
    }
}