using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACCTOnlineLibraryManagementSystem.Models
{
    public class StudentLogin
    {

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(200, MinimumLength = 6)]
        public string Password { get; set; }


        public int Fines { get; set; }

        public int NumberOfBooksBorrowed { get; set; }

       

    }
}