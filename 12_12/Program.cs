namespace _12_12
{
    internal class Program
    {
        //12) Viết chương trình minh họa sử dụng ủy quyền ñể thực hiện việc chuyển các ký tự thường thành ký tự hoa trong một chuỗi?
        public delegate char CharConversionDelegate(char c);
        public static string Convert(string input, CharConversionDelegate conversion) {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                // Áp dụng delegate để chuyển đổi từng ký tự
                result[i] = conversion(input[i]);
            }

            return new string(result);

        }
        // Phương thức chuyển ký tự thường thành ký tự hoa
        public static char ToUpperCase(char c)
        {
            return char.ToUpper(c);
        }

        static void Main(string[] args)
        {
            string input = "hello world!";

            Console.WriteLine("Original string:");
            Console.WriteLine(input);

            // Sử dụng delegate để chuyển đổi các ký tự thường thành ký tự hoa
            string result = Convert(input, ToUpperCase);

            Console.WriteLine("Converted string:");
            Console.WriteLine(result);
        }
    }
}
