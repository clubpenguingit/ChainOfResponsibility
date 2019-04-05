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

        public virtual void Handle(IRequest request)
        {
            _nextHandler?.Handle(request);
        }

        protected abstract bool CanHandle(IRequest request);
    }
}