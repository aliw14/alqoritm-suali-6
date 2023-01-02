namespace alqoritm_suali_6;
class Program
{
    static void Main(string[] args)
    {

        int count = 0;
        int sum = 0;
        int[] numbers = { 2, 3, 4, 5, 6, 7 };
        for (int i = 1; i < numbers.Length; i += 2)

        {

            if (numbers[i] % 2 == 1)
            {
                count++;
                sum += numbers[i];
            }

        }
        Console.WriteLine(sum + " " + count);
    }
}

