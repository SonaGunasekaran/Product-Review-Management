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
    }
}
