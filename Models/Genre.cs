using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BW_Bookstore.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? GenreName { get; set; }
        public List<Book>? Books { get; set; }
    }
}