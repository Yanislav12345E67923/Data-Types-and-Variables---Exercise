namespace _10._Poke_Mon;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int originalN = n;
        int countOfTargets = 0;
        while (n - m >= 0)
        {
            n -= m;
            if (n * 2 == originalN)
            {
                n /= y;
            }
            countOfTargets++;
        }

        Console.WriteLine(n);
        Console.WriteLine(countOfTargets);
    }
}

