using System.ComponentModel.DataAnnotations;

namespace FedlerApi.Models
{
    public class ListFeed
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }

        public ListFeed(int id, string title, string url)
        {
            Id = id;
            Title = title;
            Url = url;
        }
    }
}
