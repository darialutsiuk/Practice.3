namespace Practice._3;

public class BankCard
{
    private readonly string number;
    private string owner;
    private decimal limit;
    private static int count = 0;

    public BankCard(string number, string owner, decimal limit)
    {
        this.number = number;
        this.owner = owner;
        this.limit = limit;
        count++;
    }

    public BankCard(string number, string owner)
    {
        this.number = number;
        this.owner = owner;
        count++;
    }
    public decimal Limit
    {
        get { return limit; }
    }

    public string Number
    {
        get { return number; }
    }

    public string Owner
    {
        get { return owner; }
    }
}