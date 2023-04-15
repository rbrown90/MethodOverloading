namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                response = (sum == 1) ? $"{sum} dollars." : $"{sum} dollar.";
            }
            return response;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(7, 9));
            Console.WriteLine(Add(.15m, .20m));
            Console.WriteLine(Add(5, 6, true));

        }
    }
}