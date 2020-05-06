﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DinerBlazorServerApp.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name to max of 20 Characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for an order name")]
        [DisplayName("Name for the Order")]
        public string OrderName { get; set; }
    }
}
