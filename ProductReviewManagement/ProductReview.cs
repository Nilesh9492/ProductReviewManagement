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
    }
}
