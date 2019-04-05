namespace ConsoleApp2
{
    public class TwoHundredAnalyzer : BaseHandler
    {
        public TwoHundredAnalyzer(IHandler handler) : base(handler)
        {
            
        }

        public TwoHundredAnalyzer() : base()
        {
            
        }


        protected override void SpecificHandle(IRequest request)
        {
            request.Amount -= 200;
            request.Bills.Add(new Bill("200 kr."));
        }

        protected override bool CanHandle(IRequest request)
        {
            return request.Amount >= 200;
        }
    }
}
