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
                Amount = 2099,
            };
            h500.Handle(request);

            // If calling handle on the wrong handler (not the start)

            var endHandler2 = new EndHandler();
            var h502 = new FiveHundredAnalyzer(endHandler2);

            var request2 = new Request()
            {
                Amount = 90956,
            };

            endHandler2.Handle(request2);


        }
    }
}
