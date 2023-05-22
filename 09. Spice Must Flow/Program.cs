namespace _09._Spice_Must_Flow;
class Program
{
    static void Main(string[] args)
    {
        uint yleld = uint.Parse(Console.ReadLine());

        uint sum = 0;
        int days = 0;
        while (yleld >= 100)
        {
            sum += yleld;
            yleld -= 10;
            sum -= 26;
            days++;
        }
        if (sum > 26)
            sum -= 26;
        Console.WriteLine(days);
        Console.WriteLine(sum);
    }
}

