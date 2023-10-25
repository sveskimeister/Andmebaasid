using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Artwork
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public DateTime CreationYear { get; set; }
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }
    }
}
