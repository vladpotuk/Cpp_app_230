using System;

public class Money
{
    private int dollars;
    private int cents;

    public Money(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"Amount: ${dollars}.{cents:D2}");
    }

    public void SetDollars(int dollars)
    {
        this.dollars = dollars;
    }

    public void SetCents(int cents)
    {
        this.cents = cents;
    }

    public int GetDollars()
    {
        return dollars;
    }

    public int GetCents()
    {
        return cents;
    }
}
