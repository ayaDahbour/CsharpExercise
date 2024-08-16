public class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ViewProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    public Product FindProduct(string name)
    {
        return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void EditProduct(string name, string newName, decimal newPrice, int newQuantity)
    {
        var product = FindProduct(name);
        if (product != null)
        {
            product.Name = newName;
            product.Price = newPrice;
            product.Quantity = newQuantity;
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DeleteProduct(string name)
    {
        var product = FindProduct(name);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product removed.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}