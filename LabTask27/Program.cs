namespace LabTask27
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Helle", "World", "main", "array", "method" };

            char input = (char)Console.Read();

            PrintElements(arr, input);
            
        }

        public static void PrintElements(string[] arr, char element)
        {
            foreach (string s in arr)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (element == s[i])
                    {
                        Console.WriteLine("Element of array: " + s);
                        Console.WriteLine("Index of element: " + i);
                    }
                }
            }
        }
    }
}