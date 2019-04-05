namespace ConsoleApp2
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler { get; set; }

        protected BaseHandler(IHandler handler)
        {
            SetNext(handler);
        }

        protected BaseHandler()
        {
            SetNext(null);
        }

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        // Template Method
        public void Handle(IRequest request)
        {
            // If can handle
            while (CanHandle(request))
            {
                // Handle
                SpecificHandle(request);
            }
            // Cannot handle further - pass on request
            _nextHandler?.Handle(request);
        }

        // Implemented in concrete handlers
        protected abstract void SpecificHandle(IRequest request);
        protected abstract bool CanHandle(IRequest request);
    }
}