using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ProductReviewManagement;
namespace TestProductReview
{
    [TestClass]
    public class UnitTest1
    {
        List<ProductReview> product;
        ReviewManager review;
        [TestInitialize]
        public void SetUp()
        {
            review = new ReviewManager();
            product = new List<ProductReview>();
        }
        [TestMethod]
        public void TestAddReviews()
        {
            int expected = 25;
            var actual = review.AddReviews();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestRetrieveTopThreeRated()
        {
            int expected = 3;
            var actual = review.RetrieveTopThreeRated();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCountReviewUsingID()
        {
            string expected = "1 2  2 1  4 2  7 1  3 1  5 2  6 2  9 2  12 2  8 1  14 1  19 1  18 2  10 1  13 1  17 1  15 1  16 1";
            string actual = review.CountReviewUsingID();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForProductId()
        {
            string expected = "1 2 4 1 7 3 5 4 6 9 12 8 14 6 19 5 18 10 13 17 15 9 16 12 18 ";
            string actual = review.RetrieveProductIdAndReviews();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSkipTopFiveRecords()
        {
            int expected = 20;
            int actual = review.SkipTopFiveRecords();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodCountIsLikeField()
        {
            int expected = 19;
            int actual = review.CountIsLikeField();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AverageOfProductRating()
        {
            string expected = "1 7 2 10 4 9 7 4 3 6 5 8 6 9 9 7 12 3.5 8 10 14 9 19 4 18 6 10 9 13 9 17 4 15 6 16 9 ";
            string actual = review.AverageRating();
            Assert.AreEqual(expected, actual);
        }
    }
}
