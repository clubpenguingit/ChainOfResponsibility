namespace ConsoleApp2
{
    public interface IRequest
    {
        double Amount { get; set; }
        string[] Bills { get; set; }
    }
}