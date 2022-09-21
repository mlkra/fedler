using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace FedlerApi.Models
{
    public class Entry
    {
        [Required]
        [XmlElement("published")]
        public DateTime Published { get; set; }
        [Required]
        [XmlElement("title")]
        public string Title { get; set; }
        [Required]
        [XmlElement("content")]
        public string Content { get; set; }
        [Required]
        [XmlElement("id")]
        public string Id { get; set; }
        [Required]
        [XmlElement("author")]
        public Author Author { get; set; }
    }
}
