﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Final1670WebRazor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage = "Từ 1 đến 100 thôi nhập lại đi!")]
        public int DisplayOrder { get; set; }

    }
}
