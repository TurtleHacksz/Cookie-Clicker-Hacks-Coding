using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cookie Clicker Hacks - .NET Edition");
        Console.WriteLine("NuGet packages successfully installed!");
        
        // Example: Using Newtonsoft.Json
        var json = JsonConvert.SerializeObject(new { name = "Cookie Clicker", version = "1.0" });
        Console.WriteLine($"JSON: {json}");
    }
}
