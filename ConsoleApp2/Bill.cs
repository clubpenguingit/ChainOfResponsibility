namespace ConsoleApp2
{
    public class Bill : IBill
    {
        public string Amount { get; set; }

        public Bill(string Amount)
        {
            this.Amount = Amount;
        }
    }
}