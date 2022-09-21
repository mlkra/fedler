namespace FedlerApi.Models
{
    public interface IFeedRepository
    {
        public IEnumerable<ListFeed> Get();
        public Feed? Get(int id);
    }
}
