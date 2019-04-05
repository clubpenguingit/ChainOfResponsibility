using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public interface IRequest
    {
        double Amount { get; set; }
        List<Bill> Bills { get; set; }
    }
}