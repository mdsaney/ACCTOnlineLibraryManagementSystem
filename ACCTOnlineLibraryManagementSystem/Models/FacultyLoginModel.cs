using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACCTOnlineLibraryManagementSystem.Models
{
    public class FacultyLoginModel
    {
        [Required]
        [StringLength(50)]
        public string FUserName { get; set; }

        
        public bool AdminRole { get; set; }

        public int NumberOfBooksBorrowed { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(200, MinimumLength = 6)]
        public string Password { get; set; }

    }
}