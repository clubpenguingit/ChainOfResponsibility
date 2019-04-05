namespace ConsoleApp2
{
    public class FiveHundredAnalyzer : BaseHandler
    {
        public FiveHundredAnalyzer(IHandler handler) : base(handler)
        {

        }

        public FiveHundredAnalyzer() : base()
        {

        }


        protected override void SpecificHandle(IRequest request)
        {
            request.Amount -= 500;
            request.Bills.Add(new Bill("500 kr."));
        }

        protected override bool CanHandle(IRequest request)
        {
            return request.Amount >= 500;
        }
    }
}
