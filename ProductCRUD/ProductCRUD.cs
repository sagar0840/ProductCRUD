using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    public class ProductCRUD
    {
        private List<Product> products;
        public ProductCRUD()
        {
            products = new List<Product>()
            {
                new Product{Id=101,Name="Mouse",Price=799},
                new Product{Id=102,Name="Pendrive",Price=999},
            };
        }

        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }
        public void UpdateProduct(Product prod)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == prod.Id)
                {
                    products[i].Name = prod.Name;
                    products[i].Price = prod.Price;
                    break; 
                }
            }
        }
        public void DeleteProduct(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
        }
        public List<Product> List()
        {
            return products;
        }
    }

}

