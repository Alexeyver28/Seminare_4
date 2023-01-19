
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[8];
        for (int i = 0; i <= 7; i++)
        {
            Console.Write($"Введите эллемент массива под номером {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i <= 7; i++)
        {
            Console.Write(array[i] + ",");
        }
    }
}