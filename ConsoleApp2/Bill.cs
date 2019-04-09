namespace ConsoleApp2
{
    public class Bill : IBill
    {
        public string Amount { get; set; }

        public Bill(string amount)
        {
            this.Amount = amount;
        }
    }
}