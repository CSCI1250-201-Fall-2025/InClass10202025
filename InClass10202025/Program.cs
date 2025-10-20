namespace InClass10202025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "Mathew";

            float floatingPointValueButIDontLikeToUse = 0.25f;
            double floatingPointValue = 1.58;
            decimal onlyUseForMoney = 1.58M;

            byte smallValue = 125;
            short littleBitBigger = 32100;
            int standard32Bit = 1478578700;
            long standard64Bit = 1000000000000000000;

            bool tOrFalse = false;

            char singleLetter = 'A';

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);

            int[] numArray = new int[20];

            numArray[8] = 158;

            Stack<int> ints = new Stack<int>();

            int size = numArray.Length;
            
            int anothersize = numbers.Count;

            if(true)
            {

            }
            else
            {

            }

            if(false)
            {
                while(true)
                {
                   //do something

                    /*
                     * 
                     * 
                     * 
                     * 
                     * 
                     */

                }
            }
            else if(true)
            {

            }
            else
            {

            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine(name.ToUpper());



            

        }


        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}