﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesAPI.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Sales = new HashSet<Sales>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
