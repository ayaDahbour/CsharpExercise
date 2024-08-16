    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Edit a product");
                Console.WriteLine("4. Delete a product");
                Console.WriteLine("5. Search for a product");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddProduct(inventory);
                        break;
                    case "2":
                        inventory.ViewProducts();
                        break;
                    case "3":
                        EditProduct(inventory);
                        break;
                    case "4":
                        DeleteProduct(inventory);
                        break;
                    case "5":
                        SearchProduct(inventory);
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddProduct(Inventory inventory)
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter product quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            inventory.AddProduct(new Product(name, price, quantity));
            Console.WriteLine("Product added successfully.");
        }

        static void EditProduct(Inventory inventory)
        {
            Console.Write("Enter the name of the product to edit: ");
            string name = Console.ReadLine();

            var product = inventory.FindProduct(name);
            if (product != null)
            {
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();
                Console.Write("Enter new price: ");
                decimal newPrice = decimal.Parse(Console.ReadLine());
                Console.Write("Enter new quantity: ");
                int newQuantity = int.Parse(Console.ReadLine());

                inventory.EditProduct(name, newName, newPrice, newQuantity);
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void DeleteProduct(Inventory inventory)
        {
            Console.Write("Enter the name of the product to delete: ");
            string name = Console.ReadLine();

            inventory.DeleteProduct(name);
        }

        static void SearchProduct(Inventory inventory)
        {
            Console.Write("Enter the name of the product to search: ");
            string name = Console.ReadLine();

            var product = inventory.FindProduct(name);
            if (product != null)
            {
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }


