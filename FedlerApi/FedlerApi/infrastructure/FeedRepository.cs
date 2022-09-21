using FedlerApi.Models;
using System.Xml.Serialization;

namespace FedlerApi.infrastructure
{
    public class FeedRepository : IFeedRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Dictionary<int, ListFeed> _feeds;

        public FeedRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _feeds = new Dictionary<int, ListFeed>()
            {
                { 1, new ListFeed(1, "The Verge", "https://www.theverge.com/rss/index.xml") },
                { 2, new ListFeed(2, "Polygon", "https://www.polygon.com/rss/index.xml") },
            };
        }

        public IEnumerable<ListFeed> Get()
        {
            return _feeds.Values;
        }

        public Feed? Get(int feedId)
        {
            ListFeed listFeed = _feeds[feedId];
            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get, listFeed.Url
            );
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = httpClient.Send(httpRequestMessage);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = httpResponseMessage.Content.ReadAsStream();
                XmlSerializer serializer = new(typeof(Feed));
                Feed? feed = (Feed?)serializer.Deserialize(contentStream);
                return feed;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
