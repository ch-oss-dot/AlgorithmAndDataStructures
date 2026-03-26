namespace HW1
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 17;
            int y = 12;
            
            Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}");
        }
    }
}
