using System.Diagnostics;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new Client();
            var result = client.Get();

            Debug.WriteLine($"This is the result: {result}");
        }
    }
}
