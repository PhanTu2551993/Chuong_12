namespace Chuong12_11
{
    internal class Program
    {            
        //11) Viết chương trình minh họa sử dụng ủy quyền để thực hiện việc sắp xếp các số nguyên trong một mảng ?

        // Khai báo delegate để so sánh hai số nguyên
        public delegate int ComparisonDelegate(int x, int y);

        // Phương thức sắp xếp mảng sử dụng delegate
        public static void SortArray(int[] array, ComparisonDelegate comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    // So sánh hai phần tử bằng cách sử dụng delegate
                    if (comparison(array[i], array[j]) > 0)
                    {
                        // Hoán đổi nếu cần thiết
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        // Phương thức so sánh hai số theo thứ tự tăng dần
        public static int CompareAscending(int x, int y)
        {
            return x - y;
        }

        // Phương thức so sánh hai số theo thứ tự giảm dần
        public static int CompareDescending(int x, int y)
        {
            return y - x;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", numbers));

            // Sắp xếp theo thứ tự tăng dần
            SortArray(numbers, CompareAscending);
            Console.WriteLine("Sorted array in ascending order:");
            Console.WriteLine(string.Join(", ", numbers));

            // Sắp xếp theo thứ tự giảm dần
            SortArray(numbers, CompareDescending);
            Console.WriteLine("Sorted array in descending order:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
