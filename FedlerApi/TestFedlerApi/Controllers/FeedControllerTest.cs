using FedlerApi.Controllers;
using FedlerApi.Models;
using Microsoft.Extensions.Logging;

namespace TestFedlerApi.Controllers
{
    [TestClass]
    public class FeedControllerTest
    {
        private readonly FeedsController _controller;

        public FeedControllerTest()
        {
            var mockedFeedRepository = new Mock<IFeedRepository>();
            mockedFeedRepository.Setup(x => x.Get(1)).Returns(new Feed());
            _controller = new FeedsController(Mock.Of<ILogger<FeedsController>>(), mockedFeedRepository.Object);
        }

        [TestMethod]
        public void TestGetFeed()
        {
            Feed feed = _controller.Get(1);
            
            Assert.IsNotNull(feed);
        }
    }
}
