﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ICT13580013B3.Api.Model
{
    public class Product
    {
       [Key]
        public int Id
        { 
            get;
            set;
        }
        [Required]
        [MaxLength(200)]
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public decimal UnitPrice
        {
            get;
            set;
        }
        public string ImagePath
        {
            get;
            set;
        }
}
}
