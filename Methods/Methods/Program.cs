// Task1
namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 1, 4, 6, 8, 3 };
            Console.WriteLine(GetMin(arr));
        }

        public static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}





