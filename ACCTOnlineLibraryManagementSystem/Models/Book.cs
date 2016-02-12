using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACCTOnlineLibraryManagementSystem.Models
{
    public class Book
    {
        [Required]
        [StringLength(150)]
        public string BookTitle { get; set; }

        [StringLength(150)]
        public string Author { get; set; }

        [StringLength(50)]
        public string Publication { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public string EntryAt { get; set; }

        [StringLength(50)]
        public string ISBN { get; set; }
    }
}