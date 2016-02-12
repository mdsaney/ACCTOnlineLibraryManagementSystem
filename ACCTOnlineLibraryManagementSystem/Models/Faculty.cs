using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACCTOnlineLibraryManagementSystem.Models
{
    public class Faculty
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(200, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public string MemberSince { get; set; }

        public int ImageSize { get; set; }
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
    }
}