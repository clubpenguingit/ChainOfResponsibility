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

        public sealed override void Handle(IRequest request)  
        {
            // If can handle
            while(CanHandle(request))
            {
                // Handle
                request.Amount -= 100;
                request.Bills.Add(new Bill("100"));
            }
            // Cannot handle further - pass on request
            base.Handle(request);
        }

        protected override bool CanHandle(IRequest request)
        {
            return request.Amount >= 100;
        }
    }
}