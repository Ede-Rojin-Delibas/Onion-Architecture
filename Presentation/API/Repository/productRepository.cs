using API.Modals;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Security.Cryptography.X509Certificates;

namespace API.Repository
{
    public class productRepository
    {
        public List <Product> GetAll()
        {
            List<Product> products = new List<Product>();


            Product product1 = new Product() { ProductName = "Sandalye", Id = 12, Barkod = 001, stokBilgisi = 10 };
            Product product2 = new Product() { ProductName="Masa",Id = 13, Barkod=002, stokBilgisi = 20 };
            products.Add(product1);
            products.Add(product2);
            return products;


        }
        public Product GetById (int Id)
        {
            List<Product> products = new List<Product>();


            Product product1 = new Product() { ProductName = "Sandalye", Id = 12, Barkod = 001, stokBilgisi = 10,kategoriId=0021 };
            Product product2 = new Product() { ProductName = "Masa", Id = 13, Barkod = 002, stokBilgisi = 20,kategoriId=0022 };
            products.Add(product1);
            products.Add(product2);
            var model = products.Where(x=> x.Id == Id ).FirstOrDefault();

            return model;

        }
        public List<Product> GetByKıd(int KategoriId)
        {

            List<Product> products = new List<Product>();


            Product product1 = new Product() { ProductName = "Sandalye", Id = 12, Barkod = 001, stokBilgisi = 10, kategoriId = 0021 };
            Product product2 = new Product() { ProductName = "Masa", Id = 13, Barkod = 002, stokBilgisi = 20, kategoriId = 0022 };
            products.Add(product1);
            products.Add(product2);
            var model1 = products.Where(x => x.kategoriId == KategoriId).ToList();
            return model1;

        }
        public List<Product> GetByName(string name )
        {
            List<Product> products = new List<Product>();


            Product product1 = new Product() { ProductName = "Sandalye", Id = 12, Barkod = 001, stokBilgisi = 10, kategoriId = 0021 };
            Product product2 = new Product() { ProductName = "Masa", Id = 13, Barkod = 002, stokBilgisi = 20, kategoriId = 0022 };
            products.Add(product1);
            products.Add(product2);
            var model2 = products.Where(x => x.ProductName.Contains(name)).ToList();   
            return model2;

        } 
    }
}
