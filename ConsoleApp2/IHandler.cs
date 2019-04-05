namespace ConsoleApp2
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(IRequest request);
    }
}