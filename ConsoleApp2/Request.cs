using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Request : IRequest
    {
        public double Amount { get; set; }
        public List<IBill> Bills { get; set; }

        public Request()
        {
            Bills = new List<IBill>();
        }
    }
}