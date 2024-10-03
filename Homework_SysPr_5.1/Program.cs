namespace Homework_SysPr_5._1
{
    public class Program
    {
        static void Main()
        {
            //1. У вас есть массив целых чисел, и вам необходимо вычислить сумму всех элементов массива.
            //Напишите параллельную программу для вычисления суммы с использованием нескольких объектов класса Task.
            
            int[] array = { 1, 2, 3, 4, 5 };

            Parallel.ForEach(array, i =>
            {
                int res = SumNumbers(array);
                Console.WriteLine("Сумма элементов массива: {0}", res);
            });

            //Parallel.For(0, array.Length, (i) =>
            //{
            //    int res = SumNumbers(array);
            //    Console.WriteLine("Сумма элементов массива: {0}", res);
            //});

               
        }

        static int SumNumbers(int[] array )
        {
           int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
