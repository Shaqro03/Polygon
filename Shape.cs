namespace ConsoleApp26;

internal class Shape
{
    public int n;
    public string gagat;
    public void Gagat()
    {
        Console.WriteLine( "Grel gagtneri qanaky");
        do
          {
            gagat = Console.ReadLine();
            if ((int.TryParse(gagat, out n)) && n >= 3)
            {
                Console.WriteLine($"n = {n}");
                break;
            }
            else
            {
                Console.WriteLine("Goyutun chuni");
            }
           
          }
        while (true);
    }
}
