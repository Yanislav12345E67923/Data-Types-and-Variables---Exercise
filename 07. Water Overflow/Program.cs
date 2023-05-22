namespace _07._Water_Overflow;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int litersToAdd;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            litersToAdd = int.Parse(Console.ReadLine());

            if (sum + litersToAdd <= 255)
            {
                sum += litersToAdd;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }
        Console.WriteLine(sum);
    }
}

