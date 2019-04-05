using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var h1 = new OneHundredAnalyzer();
            var h50 = new FiftyAnalyzer(h1);
            var request = new Request()
            {
                Amount = 550,
            };
            h50.Handle(request);
            foreach (var requestBill in request.Bills)
            {
                Console.WriteLine($"{requestBill.Amount}");
                
            }

            Console.WriteLine($"Rest is {request.Amount}");
        }
    }
}
