﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace eShop.DatabaseRepository.DbModels
{
    public partial class Units
    {
        public Units()
        {
            Products = new HashSet<Products>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}