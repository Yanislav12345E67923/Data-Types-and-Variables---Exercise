namespace _08._Beer_Kegs;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string theName = null;
        double theBest = 0.0;
        string name = null;
        double r = 0.0;
        int h = 0;
        for (int i = 0; i < n; i++)
        {
            name = Console.ReadLine();
            r = double.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());

            if (Math.Pow(r, 2) * h > theBest)
            {
                theBest = Math.Pow(r, 2) * h;
                theName = name;
            }
        }
        Console.WriteLine(theName);
    }
}

