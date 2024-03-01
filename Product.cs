using System;

public class Product
{
    private string name;
    private Money price;

    public Product(string name, int dollars, int cents)
    {
        this.name = name;
        this.price = new Money(dollars, cents);
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {name}");
        price.DisplayAmount();
    }

    public void DecreasePrice(int discountDollars, int discountCents)
    {
        int newDollars = price.GetDollars() - discountDollars;
        int newCents = price.GetCents() - discountCents;

        if (newCents < 0)
        {
            newDollars--;
            newCents += 100;
        }

        price.SetDollars(newDollars);
        price.SetCents(newCents);
    }
}
