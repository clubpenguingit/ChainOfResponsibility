namespace ConsoleApp2
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler { get; set; }

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void Handle(IRequest request);
    }
}