using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace FedlerApi.Models
{
    public class Author
    {
        [Required]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
