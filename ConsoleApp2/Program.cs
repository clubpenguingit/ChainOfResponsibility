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
            // Initializing the chain of responsibility from end to start. 
            var endHandler = new EndHandler();
            var h50 = new FiftyAnalyzer(endHandler);
            var h100 = new OneHundredAnalyzer(h50);
            var h200 = new TwoHundredAnalyzer(h100);
            var h500 = new FiveHundredAnalyzer(h200);
            
            var request = new Request()
            {
                Amount = 90956,
            };
            h500.Handle(request);

            
        }
    }
}
