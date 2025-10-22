

using System.Globalization;

namespace InClass10202025
{
    public class Program
    {
        public static void Main(string[] args)
        {
         

            //float floatingPointValueButIDontLikeToUse = 0.25f;
            double floatingPointValue = 1.58;
            // Depends always user for money! decimal onlyUseForMoney = 1.58M;

           // byte smallValue = 125;
            //short littleBitBigger = 32100;
            int standard32Bit = 1478578700;
           // long standard64Bit = 1000000000000000000;

            bool tOrFalse = false;

            char singleLetter = 'A';

            List<int> numbers = new List<int>();

            string name = "Mathew";

           //String name = new String("Mathew");

            List<string> names = new List<string>();

            List<string> newNames = new List<string>(names);

            int[] numArray = new int[20];

          
            numArray[8] = 158;

            int size = numArray.Length;
            
            int anothersize = numbers.Count;

            if(3 > 4 || 5 > 7 && "Mathew" == "Mathew")
            {
                //never runs!!!
            }
            else
            {
                // runs because above is false!
            }

            if(false)
            {
            }
            else if (true)
            {

            }
            else
            {

            }
            //int counter = 0;

            //Console.WriteLine(++counter);

            //Console.WriteLine(counter);
           // Console.WriteLine(newValue);


            for (int i = 0; i < 50; i++)
            {
                Random r = new Random();

                numbers.Add(r.Next(100) + 1);
            }
            

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            int userChoice = 0;

            //while(x != 4)
            //{


            //    //at some point change to not have an infinte loop
            //}

            //do
            //{
              
                
            //    Utility.ClearScreen();
            //    Console.WriteLine("Please select a number  1 - 4. ");
            //    try
            //    {
            //        userChoice = int.Parse(Console.ReadLine());
            //        if("bad" == "ReallyBad")
            //        {
            //            throw new Exception();
            //        }
            //    }
            //    catch(Exception e)
            //    {
                    
            //    }
               
            //} while(userChoice != 4);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine(name.ToUpper());


            Person person1 = new Person();
            person1.Id = 1;
            person1.FirstName = "Mathew";
            person1.LastName = "Desjardins";
            person1.StoreId = 1;
            person1.Store = new Store { Id = 1, Name = "Amazing Store!" };


            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();

            List<Animal> animals = new List<Animal>();

            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(cat1);
            animals.Add(cat2);

            foreach (var item in animals)
            {
                Console.WriteLine(item.Speak());
            }



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