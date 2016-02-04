using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACCTOnlineLibraryManagementSystem.Models
{
    public class Student
    {
        [Required]
        [StringLength(250)]
        public string StudentName { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }

        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public string MemberSince { get; set; }

    }
}