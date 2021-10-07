using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name="Enter name")]
        [MinLength(1)]
        [Required(ErrorMessage ="Name length more or equals 1 character")]
        public string name { get; set; }
        [Display(Name = "Enter surname")]
        [MinLength(1)]
        [Required(ErrorMessage = "Surname length more or equals 1 character")]
        public string surname { get; set; }
        [Display(Name = "Adress")]
        [MinLength(1)]
        [Required(ErrorMessage = "Adress shuold be fullfilled")]
        public string adress { get; set; }
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(1)]
        [Required(ErrorMessage = "Phone number shold be fullfilled")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        [DataType((DataType.EmailAddress))]
        [MinLength(1)]
        [Required(ErrorMessage = "Email should be fullfiled")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime ordertime { get; set; }
        public List<OrderDetail> orderDetail { get; set; }

    }
}
