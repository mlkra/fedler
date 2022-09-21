using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace FedlerApi.Models
{
    [XmlRoot("feed", Namespace = "http://www.w3.org/2005/Atom")]
    public class Feed
    {
        [Required]
        [XmlElement("title")]
        public string Title { get; set; }
        [Required]
        [XmlElement("icon")]
        public string Icon { get; set; }
        [Required]
        [XmlElement("updated")]
        public DateTime Updated { get; set; }
        [Required]
        [XmlElement("id")]
        public string Id { get; set; }
        [Required]
        [XmlElement("entry")]
        public List<Entry> Entries { get; set; }
    }
}
