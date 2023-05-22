namespace _06._Triples_of_Latin_Letters;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int one = 97; one < 97 + n; one++)
        {
            for (int two = 97; two < 97 + n; two++)
            {
                for (int three = 97; three < 97 + n; three++)
                {
                    Console.WriteLine($"{(char)one}{(char)two}{(char)three}");
                }
            }
        }
    }
}

