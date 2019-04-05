namespace ConsoleApp2
{
    public class OneHundredAnalyzer : BaseHandler
    {
        public OneHundredAnalyzer(IHandler handler) : base(handler)
        {

        }

        public OneHundredAnalyzer() : base()
        {
            
        }

        protected override void SpecificHandle(IRequest request)
        {
            request.Amount -= 100;
            request.Bills.Add(new Bill("100 kr."));
        }

        protected override bool CanHandle(IRequest request)
        {
            return request.Amount >= 100;
        }
    }
}