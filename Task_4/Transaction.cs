namespace Task_4;

public class Transaction
{
    public int Id { get; set; }
    public DateTime date { get; set; }
    public decimal amount { get; set; }
    
    public TransactionType Type { get; set; }
}