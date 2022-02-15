using System.Collections.Generic;
using System.Data.Entity;

namespace ProjektPIN.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "SOK Smokva"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "SOK Rajcica"
                },
                
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "SOK Suha Smokva",
                    Description = "Jednostavni i zdravi sok od listova smokve ,  pomaze kod visokog  tlaka , povisenog secera , kolesterola , a i kod osteoporoze.",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "SOK Mlada Smokva",
                    Description = "Jednostavni i zdravi sok od listova smokve ,  pomaze kod visokog  tlaka , povisenog secera , kolesterola , a i kod osteoporoze .",
                    ImagePath="carearly.png",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                
                new Product
                {
                    ProductID = 3,
                    ProductName = "SOK Cherry Rajcica",
                    Description = "Organski sok od rajčice je proizveden kuhanjem svježe propasirane rajčice u vakumskom uparivaču, što osigurava niže temperature kuhanja.",
                    ImagePath="planeace.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "SOK Regular Rajcica",
                    Description = "Organski sok od rajčice je proizveden kuhanjem svježe propasirane rajčice u vakumskom uparivaču, što osigurava niže temperature kuhanja.",
                    ImagePath="rajcica1.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                
                
            };

            return products;
        }
    }
}