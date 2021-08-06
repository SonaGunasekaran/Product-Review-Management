using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class ReviewManager
    {
        List<ProductReview> product;
        public ReviewManager()
        {
            product = new List<ProductReview>();
        }
        public int AddReviews()
        {
            product.Add(new ProductReview() { ProductId = 1, UserId = 3, Rating = 5, Review = "Average", IsLike = true });
            product.Add(new ProductReview() { ProductId = 2, UserId = 8, Rating = 10, Review = "Very Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 4, UserId = 6, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 1, UserId = 2, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 7, UserId = 1, Rating = 4, Review = "Bad", IsLike = false });
            product.Add(new ProductReview() { ProductId = 3, UserId = 9, Rating = 6, Review = "Average", IsLike = true });
            product.Add(new ProductReview() { ProductId = 5, UserId = 1, Rating = 10, Review = "Very Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 4, UserId = 4, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 6, UserId = 5, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 9, UserId = 10, Rating = 4, Review = "Bad", IsLike = false });
            product.Add(new ProductReview() { ProductId = 12, UserId = 9, Rating = 6, Review = "Average", IsLike = true });
            product.Add(new ProductReview() { ProductId = 8, UserId = 11, Rating = 10, Review = "Very Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 14, UserId = 14, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 6, UserId = 15, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 19, UserId = 10, Rating = 4, Review = "Bad", IsLike = false });
            product.Add(new ProductReview() { ProductId = 5, UserId = 13, Rating = 6, Review = "Average", IsLike = true });
            product.Add(new ProductReview() { ProductId = 18, UserId = 1, Rating = 10, Review = "Very Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 13, UserId = 6, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 17, UserId = 7, Rating = 4, Review = "Bad", IsLike = false });
            product.Add(new ProductReview() { ProductId = 15, UserId = 19, Rating = 6, Review = "Average", IsLike = true });
            product.Add(new ProductReview() { ProductId = 9, UserId = 11, Rating = 10, Review = "Very Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 16, UserId = 17, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 12, UserId = 6, Rating = 1, Review = "Bad", IsLike = false });
            product.Add(new ProductReview() { ProductId = 18, UserId = 7, Rating = 2, Review = "Bad", IsLike = false });
            IterateMethod(product);
            return product.Count;
        }
        public void IterateMethod(List<ProductReview> products)
        {
            foreach (ProductReview product in products)
            {
                Console.WriteLine("Product Id:{0}\tUser Id:{1}\tRating:{2}\tReview:{3}\tIsLike:{4}", product.ProductId, product.UserId, product.Rating, product.Review, product.IsLike);
            }
        }
        //UC2----->Retrieve Top three rating
        public int RetrieveTopThreeRated()
        {
            AddReviews();
            Console.WriteLine(" ");
            Console.WriteLine("Retieve Top Three Products from the list");
            var result = (from products in product orderby products.Rating descending select products).Take(3).ToList();
            IterateMethod(result);
            return result.Count;
        }
        //UC3----->Retrieve Rating Greater than 3
        public List<ProductReview> RetrieveRatingGreaterThanThree()
        {
            AddReviews();
            var result = (from products in product where (products.Rating > 3) && (products.ProductId == 1 || products.ProductId == 4 || products.ProductId == 9) select products).ToList();
            IterateMethod(result);
            return result;
        }
        //UC4----->Retrieve count of review present for each productID
        public string CountReviewUsingID()
        {
            string result = "";
            AddReviews();
            var countId = product.GroupBy(x => x.ProductId).Select(p => new { ProductId = p.Key, count = p.Count() });
            foreach (var c in countId)
            {
                Console.WriteLine("Product Id:{0}\tCount:{1}", c.ProductId, c.count);
                result += " " + c.ProductId + " " + c.count + " ";
            }
            return result;
        }
        //UC5------->Retrieve Only Product and Reviews
        public string RetrieveProductIdAndReviews()
        {
            string result = "";
            AddReviews();
            var res = product.Select(p => new { ProductId = p.ProductId, Review = p.Review }).ToList();
            foreach (var x in res)
            {
                Console.WriteLine("ProductId " + x.ProductId + " " + "Review " + " " + x.Review);
                result += x.ProductId + " ";
            }
            return result;
        }
        //UC6------->Skip the Top Five Ratings
        public int SkipTopFiveRecords()
        {
            AddReviews();
            Console.WriteLine(" ");
            Console.WriteLine("Skip Top Five Records from the list");
            var result = (from products in product orderby products.Rating descending select products).Skip(5).ToList();
            IterateMethod(result);
            return result.Count;
        }
        //UC8------>Create Data Table
        public DataTable CreateDataTable(List<ProductReview> list)
        {
            AddReviews();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("rating");
            dt.Columns.Add("Reviews");
            dt.Columns.Add("IsLike");
            foreach (var d in list)
            {
                dt.Rows.Add(d.ProductId, d.UserId, d.Rating, d.Review, d.IsLike);
            }
            IterateDataTable(dt);
            return dt;
        }
        public void IterateDataTable(DataTable dataTable)
        {
            var result = (from table in dataTable.AsEnumerable() select table.Field<string>("ProductId")).ToList();
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

        }
       //UC9------->Retrieve all the records from the datatable variable who’s isLike value is true
        public int CountIsLikeField()
        {
            List<ProductReview> products = new List<ProductReview>();
            DataTable table = CreateDataTable(products);
            int count = 0;
            var result = table.AsEnumerable().Where(x => x.Field<string>("IsLike").Equals("true")).Select(x => x.Field<string>("ProductId")).ToList();
            foreach (var t in result)
            {
                Console.WriteLine(t);
                count++;
            }
            return count;
        }
        //UC10-------->Find average rating of the each productId
        public string AverageRating()
        {
            AddReviews();
            string result = "";
            var res = product.GroupBy(p => p.ProductId, r => r.Rating).Select(x => new { ProductId = x.Key, Average = x.Average() });
            foreach (var a in res)
            {
                Console.WriteLine("Product Id:{0}\tAverageOfRating:{1}", a.ProductId, a.Average);
                result += a.ProductId + " " + a.Average + " ";
            }
            return result;
        }
        //UC11--------->Retreive all records from the list who’s review message contain good
        public int RetrivingListContainGood()
        {
            AddReviews();
            string result = " ";
            int count = 0;
            var res = product.Select(x => new { Review = x.Review.Equals("Good") }).ToList();
            foreach (var r in res)
            {
                Console.WriteLine("Review " + " " + r.Review);
                result += r.Review + " ";
                count++;
            }
            Console.WriteLine(count);
            return count;

        }
    }
}

