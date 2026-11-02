using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_11._1.Models
{
    public class BookInventory
    {
        [Key]
        public int ISBN {  get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
    }
}
