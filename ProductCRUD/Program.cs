using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductCRUD productCRUD = new ProductCRUD();
            int c = 0;
            do
            {
                Console.Clear(); 
                Console.WriteLine("1. Product List");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("select above option");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        List<Product> prods = productCRUD.List();
                        Console.WriteLine("Id \t Name \t\t Price");
                        foreach (Product p in prods)
                        {
                            Console.WriteLine($"{p.Id} \t {p.Name} \t\t {p.Price}");
                        }
                        break;
                    case 2:
                        Product p1 = new Product();
                        Console.WriteLine("Enter Id");
                        p1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        p1.Price = Convert.ToInt32(Console.ReadLine());
                        productCRUD.AddProduct(p1);
                        Console.WriteLine("Product added..");
                        break;

                    case 3:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Id");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new product name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter new Price");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        productCRUD.UpdateProduct(p2);
                        Console.WriteLine("Product updated..");
                        break;
                    case 4:
                        Console.WriteLine("Enter Id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        productCRUD.DeleteProduct(id);
                        Console.WriteLine("Product deleted..");
                        break;
                    default:
                        Console.WriteLine("Wrong option selection..");
                        break;
                }
                Console.WriteLine("Select 1 for continue");
                c = Convert.ToInt32((Console.ReadLine()));
            }
            while (c == 1);
        }

    }
}

