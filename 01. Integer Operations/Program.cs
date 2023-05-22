namespace _01._Integer_Operations;
class Program
{
    static void Main(string[] args)
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());
        long thirdNum = long.Parse(Console.ReadLine());
        long fourthNum = long.Parse(Console.ReadLine());

        long one = firstNum + secondNum;
        long two = one / thirdNum;
        long three = two * fourthNum;
        Console.WriteLine(three);
    }
}

