using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

        public static void AddProductReview(List<ProductReview> products)
        {
            products.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 2, UserId = 2, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 3, UserId = 3, Rating = 5, Review = "Bad", isLike = true });
            products.Add(new ProductReview() { ProductId = 4, UserId = 4, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 5, UserId = 5, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 6, UserId = 6, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 7, UserId = 7, Rating = 6, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 8, UserId = 8, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 9, UserId = 9, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 11, UserId = 11, Rating = 10, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 12, UserId = 12, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 13, UserId = 13, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 14, UserId = 14, Rating = 2, Review = "Very Bad", isLike = true });
            products.Add(new ProductReview() { ProductId = 15, UserId = 15, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 16, UserId = 16, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 17, UserId = 17, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 18, UserId = 18, Rating = 7, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 19, UserId = 19, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 20, UserId = 20, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 21, UserId = 21, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 22, UserId = 23, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 23, UserId = 23, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 24, UserId = 24, Rating = 6, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 25, UserId = 25, Rating = 9, Review = "Good", isLike = true });

            foreach (var i in products)
            {
                Console.WriteLine("Product Id :" + i.ProductId + ", User Id :" + i.UserId + ", Rating :" + i.Rating + ", REview :" + i.Review);
            }
        }
    

        public static void RetrieveTopThreeRecords(List<ProductReview> products)
        {
            Console.WriteLine("Top three records are");
            var res = (from product in products orderby product.Rating descending select product).Take(3).ToList();
            IterateMethod(res);
        }
        public static void IterateMethod(List<ProductReview> products)
        {
            foreach (var i in products)
            {
                Console.WriteLine("Product Id :" + i.ProductId + ", User Id :" + i.UserId + ", Rating :" + i.Rating + ", REview :" + i.Review);
            }
        }
        public static void Retrieve(List<ProductReview> products)
        {
            Console.WriteLine("Records greater than 7 rating among 1,11,13 are");
            var result = (from product in products where product.Rating > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) select product).ToList();
            IterateMethod(result);
        }
        public static void RetrieveCount(List<ProductReview> products)
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
    }
}
