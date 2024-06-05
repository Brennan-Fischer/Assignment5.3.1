namespace Assignment5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines if you can plant n number of flower in flower bed array input by user with no flowers being next to another flower");
            Console.WriteLine("Input number of flowers");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input size of Array");
            int size= Convert.ToInt32(Console.ReadLine());
            int[] flowerBed = new int[size];
            for (int i = 0;i<size;i++)
            {
                Console.WriteLine($"input {i} element");
                flowerBed[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i<flowerBed.Length;i++)
            {
                if (flowerBed[i - 1] == 0 && flowerBed[i] == 0 && flowerBed[i + 1] == 0)
                { flowerBed[i] = 1; n--; }
                if (n == 0)
                {
                    Console.WriteLine("Flowers fit in flower bed as depicted");
                    foreach (int number in flowerBed) { Console.WriteLine(number);
                        break;
                    }
                }



            }
            if (n != 0) { Console.WriteLine("Flowers cannot fit"); }
        }
    }
}
