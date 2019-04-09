using System;

namespace ConsoleApp2
{
    public class EndHandler : BaseHandler
    {
        private bool _handled = false;
        // Output results and print anything unhandled. 
        protected override void SpecificHandle(IRequest request)
        {
            Console.WriteLine("Printing Bills.");
            // Print all the bills
            foreach (var requestBill in request.Bills)
            {
                Console.WriteLine($"{requestBill.Amount}");

            }
            // Print anything unhandled
            if (request.Amount != 0.0)
                Console.WriteLine($"Could not cash out the last {request.Amount} kr.");
            
        }

        // Must always catch the request as this is the end of the chain.
        // But only once 
        protected override bool CanHandle(IRequest request)
        {
            if (!_handled)
            {
                _handled = true;
                return _handled;
            }
            else
                return !_handled;
        }
    }
}