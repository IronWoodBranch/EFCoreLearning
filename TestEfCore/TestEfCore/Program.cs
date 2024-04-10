namespace TestEfCore
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            using(PaymentDbContext ctx = new PaymentDbContext())
            {
                Payment newPay = new Payment()
                {
                    PayDate = DateTime.Now,
                    Amount = 2600,
                    Category = "buying",
                    Description = "bread"
                };
                ExpenseJournal newJournal = new ExpenseJournal() { JournalName = "food", UserID = 1 };
                ctx.Add(newPay);
                ctx.Add(newJournal);
                await ctx.SaveChangesAsync();
            }
        }
    }
}
