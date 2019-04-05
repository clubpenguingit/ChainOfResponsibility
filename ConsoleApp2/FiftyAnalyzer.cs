namespace ConsoleApp2
{
    public class FiftyAnalyzer : BaseHandler
    {
        public FiftyAnalyzer(IHandler handler) : base(handler)
        {
            
        }
        public FiftyAnalyzer() : base()
        {
            
        }
        protected override void SpecificHandle(IRequest request)
        {
            request.Amount -= 50;
            request.Bills.Add(new Bill("50 kr."));
        }

        protected override bool CanHandle(IRequest request)
        {
            return request.Amount >= 50;
        }
    }
}