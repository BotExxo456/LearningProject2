internal class Program1
{
    private static void Main(string[] args)
    {
        for(int counter = 0; counter < 50; counter+=5)
        {
            Console.WriteLine(counter);
        }
        

        for(int odd = 0; odd < 20; odd++)
        {
            if (odd % 2 != 0)
            {
                Console.WriteLine(odd);
            }
            
        }  
        Console.Read();
    }
}