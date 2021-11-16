using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace ProductReviewManagement
{
    class ProductReview
    { 

        public static void AddProductReview(List<Product> products)
        {
            products.Add(new Product() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 2, UserId = 2, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 3, UserId = 3, Rating = 5, Review = "Bad", isLike = true });
            products.Add(new Product() { ProductId = 4, UserId = 4, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 5, UserId = 5, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 6, UserId = 6, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 7, UserId = 7, Rating = 6, Review = "Average", isLike = true });
            products.Add(new Product() { ProductId = 8, UserId = 8, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 9, UserId = 9, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 10, UserId = 10, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 11, UserId = 11, Rating = 10, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 12, UserId = 12, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 13, UserId = 13, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 14, UserId = 14, Rating = 2, Review = "Very Bad", isLike = true });
            products.Add(new Product() { ProductId = 15, UserId = 15, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 16, UserId = 16, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 17, UserId = 17, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 18, UserId = 18, Rating = 7, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 19, UserId = 19, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 20, UserId = 20, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 21, UserId = 21, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 22, UserId = 23, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 23, UserId = 23, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 24, UserId = 24, Rating = 6, Review = "Average", isLike = true });
            products.Add(new Product() { ProductId = 25, UserId = 25, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 26, UserId = 10, Rating = 9, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 27, UserId = 10, Rating = 7, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 28, UserId = 10, Rating = 8, Review = "Good", isLike = true });
            products.Add(new Product() { ProductId = 29, UserId = 10, Rating = 5, Review = "Bad", isLike = true });
            products.Add(new Product() { ProductId = 30, UserId = 10, Rating = 10, Review = "Good", isLike = true });

            foreach (var i in products)
            {
                Console.WriteLine("Product Id :" + i.ProductId + ", User Id :" + i.UserId + ", Rating :" + i.Rating + ", REview :" + i.Review);
            }
        }
        public static void IterateMethod(List<Product> products)
        {
            foreach (var i in products)
            {
                Console.WriteLine("Product Id :" + i.ProductId + ", User Id :" + i.UserId + ", Rating :" + i.Rating + ", REview :" + i.Review);
            }
        }

        public static void RetrieveTopThreeRecords(List<Product> products)
        {
            Console.WriteLine("Top three records are");
            var res = (from product in products orderby product.Rating descending select product).Take(3).ToList();
            IterateMethod(res);
        }
        
        public static void Retrieve(List<Product> products)
        {
            Console.WriteLine("Records greater than 7 rating among 1,11,13 are");
            var result = (from product in products where product.Rating > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) select product).ToList();
            IterateMethod(result);
        }
        public static void RetrieveCount(List<Product> products)
        {
            int n = 0;

            var rev = products.GroupBy(p => p.Rating).Select(x => new { ID = x.Key, count = x.Count() });
            foreach (var i in rev)
            {
                Console.WriteLine("ProductId : " + i.ID + "\tcount : " + i.count);
                n++;
            }
            Console.WriteLine(n);
        }
        public static void RetrieveIdAndReview(List<Product> products)
        {
            var rev = products.Select(s => new { Id = s.ProductId, review = s.Review });

            foreach (var i in rev)
            {
                Console.WriteLine("Product ID :" + i.Id + " Review :" + i.review);
            }
        }
        public static void SkipRecords(List<Product> products)
        {
            Console.WriteLine("Products After skipping Top 5 records are ");
            var res = (from product in products orderby product.ProductId ascending select product).Skip(5).ToList();
            IterateMethod(res);
        }
    }
}
