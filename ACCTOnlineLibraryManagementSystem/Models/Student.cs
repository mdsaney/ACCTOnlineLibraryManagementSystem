﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACCTOnlineLibraryManagementSystem.Models
{
    public class Student
    {
        [Required]
        [StringLength(250)]
        [Remote("doesRegIDExist", "Account", HttpMethod = "POST", ErrorMessage = "Registration ID already exists. Please enter a different Registrtation ID.")]
        public string RegID { get; set; }

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
        [DataType(DataType.Password)]
        [StringLength(200, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(12)]
        public string Contact { get; set; }

        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        

        public int ImageSize { get; set; }
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }

    }
}