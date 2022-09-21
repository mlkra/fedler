using FedlerApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FedlerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedsController : ControllerBase
    {
        private readonly ILogger<FeedsController> _logger;
        private readonly IFeedRepository _feedRepository;

        public FeedsController(ILogger<FeedsController> logger, IFeedRepository feedRepository)
        {
            _logger = logger;
            _feedRepository = feedRepository;
        }

        [HttpGet(Name = "GetFeeds")]
        public IEnumerable<ListFeed> Get()
        {
            return _feedRepository.Get();
        }

        [HttpGet("{id}", Name = "GetFeed")]
        public Feed Get(int id)
        {
            Feed? feed = _feedRepository.Get(id);
            if (feed != null)
            {
                return feed;
            } else
            {
                throw new Exception();
            }
        }
    }
}
