using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    class ProductTable
    {
        public static DataTable AddDetails(List<Product> products)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserId");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

            foreach (var i in products)
            {
                var row = table.NewRow();
                row["ProductId"] = i.ProductId;
                row["UserId"] = i.UserId;
                row["Rating"] = i.Rating;
                row["Review"] = i.Review;
                row["isLike"] = i.isLike;
                table.Rows.Add(row);
            }
            ViewTable(table);
            return table;
        }
        public static void ViewTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {

                foreach (var i in row.ItemArray)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public static int RetrieveBasedOnIsLike(List<Product> products)
        {
            int count = 0;
            DataTable table = AddDetails(products);
            var res = from t in table.AsEnumerable() where t.Field<bool>("isLike") == true select t;
            foreach (var i in res)
            {
                Console.WriteLine($"{i["isLike"]}");
                count++;
            }
            return count;
        }
        public static void AverageRating(List<Product> products)
        {
            DataTable table = AddDetails(products);
            double avg = (double)table.AsEnumerable().Average(x => x.Field<int>("Rating"));
            Console.WriteLine("Average of ratings of all products is ");
            Console.WriteLine(avg);
        }

    }
}
