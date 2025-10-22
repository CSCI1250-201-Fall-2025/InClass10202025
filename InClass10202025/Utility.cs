using System.Text.RegularExpressions;

namespace InClass10202025
{
    public class Utility
    {
        public static void ClearScreen()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("\n");
            }
        }

        public static int Add(int num1, int num2, int num3, int num4)
        {
            return Add(num1, num2, num3) + num4;
        }
        public static int Add(int num1, int num2, int num3)
        {
            return Add(num1, num2) + num3;
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
       



    }
}
