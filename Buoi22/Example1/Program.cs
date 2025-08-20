namespace Example1;

public class Program
{
    public static void Main(string[] args)
    {
        Repository<Product> productRepository = new Repository<Product>();

        Product product1 = new Product { Name = "Laptop", Price = 1200.00m };
        Product product2 = new Product { Name = "Smartphone", Price = 800.00m };
        Product product3 = new Product { Name = "Tablet", Price = 400.00m };
        Product product4 = new Product { Name = "Smartwatch", Price = 200.00m };
        Product product5 = new Product { Name = "Headphones", Price = 150.00m };
        Product product6 = new Product { Name = "Monitor", Price = 300.00m };
        Product product7 = new Product { Name = "Keyboard", Price = 100.00m };
        Product product8 = new Product { Name = "Mouse", Price = 50.00m };

        productRepository.Add(product1);
        productRepository.Add(product2);
        productRepository.Add(product3);
        productRepository.Add(product4);
        productRepository.Add(product5);    
        productRepository.Add(product6);
        productRepository.Add(product7);
        productRepository.Add(product8);
        
        Console.WriteLine("Products in repository:");
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine(product);
        }

        productRepository.Remove(product1);
        Console.WriteLine("\nAfter removing Laptop:");
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine(product);
        }
    }
}
