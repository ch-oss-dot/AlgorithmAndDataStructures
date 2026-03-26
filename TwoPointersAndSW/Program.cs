using System.Diagnostics.Metrics;

namespace TwoPointersAndSW
{
    internal class Program
    {
        static int[]? TwoSum(int[] arr, int target)
        {
            if (arr is null || arr.Length <= 1) return null;//возвращается массив
            //не очень желательно пустой ссылки(ставим ?)
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)//линейное время
            {
                if (arr[left] + arr[right] > target) right--;
                else
                {
                    if (arr[left] + arr[right] < target) left++;
                    else return [left+1, right+1];

                }
                
            }
            return null;
        }
        static int[]? Square(int[] arr)
        {
            if (arr is null ) return null;
            if (arr.Length == 0) return arr;
            int left = 0;
            int right = arr.Length - 1;
            int[] res = new int[arr.Length];
            for(int k =arr.Length -1; left<= right; k--)//линейное
            {
                if (arr[left] * arr[left] < arr[right] * arr[right])
                {
                    res[k] = arr[right] * arr[right];
                    right--;
                }
                else res[k] = arr[left] * arr[left++];
            }
            return res;
        }

        static int? Counter(int[] arr, int k)
        {
            if (arr is null) return null;
            if (arr.Length == 0) return 0;

            int top = 0;
            int bottom = 0;
            int max = 0, count = 0;
            while (top < arr.Length - 1)
            {
                if (count <= k || count <= k && arr[top + 1] == 1)
                {
                    top++;
                    if (arr[top] == 0)
                        count++;
                }
                else
                {

                }
            }
        }

        static void Main(string[] args)
        {

            //int[] mass = { 2, 7, 11, 15 };
            //int[]? res = TwoSum(mass, 9);//вопрос чтоб знать что вернуться null
            //if (res is null)
            //    Console.WriteLine("Таких нет");
            //else
            //{
            //    Console.Write(res[0] + " " + res[1]);
            //    Console.WriteLine();
            //    Console.WriteLine(mass[res[0] - 1] + " " + mass[res[1] - 1]);
            //}
            //int[]? res1 = Square([-4, -1, 0, 3, 10]);
            //if (res1 is null) Console.WriteLine("error");
            //else
            //{
            //    foreach (int i in res1) Console.Write(i + " ");
            //}
            Counter();
        }
        
        
    }
}
