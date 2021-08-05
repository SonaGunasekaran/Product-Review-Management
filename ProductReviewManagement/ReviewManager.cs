using System;
using System.Collections.Generic;
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
            product.Add(new ProductReview() { ProductId = 12, UserId = 6, Rating = 9, Review = "Good", IsLike = true });
            product.Add(new ProductReview() { ProductId = 18, UserId = 7, Rating = 4, Review = "Bad", IsLike = false });
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
        public int RetrieveTopThreeRated()
        {
            AddReviews();
            Console.WriteLine(" ");
            Console.WriteLine("Retieve Top Three Products from the list");
            var result = (from products in product orderby products.Rating descending select products).Take(3).ToList();
            IterateMethod(result);
            return result.Count;
        }
    }
}

