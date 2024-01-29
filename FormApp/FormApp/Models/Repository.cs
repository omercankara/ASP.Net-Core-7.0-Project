//List<Product> Models içindeki product.cs dosyası ile aynı isimde olmalı 
namespace FormApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();
        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1,Name="Computer"});
            _categories.Add(new Category { CategoryId = 2, Name = "Phone" });
            _products.Add(new Product { ProductId = 1,Name="IPhone 14",Price=40000,IsActive=true,Image="1.jpg",CategoryId=2 });
            _products.Add(new Product { ProductId = 2, Name = "IPhone 15 ", Price = 45000, IsActive = true, Image = "1.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 3, Name = "IPhone 16 ", Price = 55000, IsActive = true, Image = "2.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 4, Name = "IPhone 17 ", Price = 65000, IsActive = true, Image = "3.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, Name = "Macbook Air", Price = 55000, IsActive = true, Image = "5.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 7, Name = "Macbook Pro", Price = 65000, IsActive = true, Image = "6.jpg", CategoryId = 1 });
        }

        //Product Oluştur
        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        //Product Editl
        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if(entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;    
                entity.IsActive = updatedProduct.IsActive;  
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;  
            }
        }
        public static void DeleteProduct(Product deletedProduct)
        {
			var model = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);
            if(model != null)
            {
               _products.Remove(model);
            }
		}

        //private olan üyeyi dışarıya aç
        public static  List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
  
}
