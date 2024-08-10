namespace Task_4;

public class TransactionManager
{
    List<Transaction>l = new List<Transaction>();

    public void AddTransaction(Transaction transaction)
    {
        try
        {
            l.Add(transaction);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public List<Transaction> GetTransactions(int year)
    {
        try
        {
            if(l.FindAll(x => x.date.Year.Equals(year)) != null)
            {
                return l.FindAll(x => x.date.Year.Equals(year));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return null;
    }

    public decimal TotalScales(DateTime year1, DateTime year2)
    {
        decimal amountt = 0;
        try
        {
            List<Transaction>l2 = l.FindAll(x => x.date >= year1 && x.date <= year2);
            for (int i = 0; i < l2.Count; i++)
            {
                if (l2[i].Type == TransactionType.Purchase)
                {
                    amountt+=l2[i].amount;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return amountt;
    }

    public List<Transaction> FirstAndLast()
    {
        List<Transaction>l2 = new List<Transaction>();
        l2.Add(l[0]);
        l2.Add(l[l.Count-1]);
        return l2;
    }
}