class Program
{
    static void Main()
    {
        Money money1 = new Money(10, 50);
        money1.DisplayAmount();

        Money money2 = new Money(5, 25);
        money2.DisplayAmount();

        Product product1 = new Product("Laptop", 800, 0);
        product1.DisplayProductInfo();

        Product product2 = new Product("Headphones", 100, 50);
        product2.DisplayProductInfo();

        product2.DecreasePrice(20, 30);
        product2.DisplayProductInfo();
    }
}
