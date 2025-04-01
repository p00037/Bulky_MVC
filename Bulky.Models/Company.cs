using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models {
    public class Company {
        public int Id { get; set; }

        [Display(Name = "会社名")]
        [Required(ErrorMessage = "{0}は必須項目です。")]
        public string Name { get; set; } = "";

        [Display(Name = "番地")]
        public string? StreetAddress { get; set; }

        [Display(Name = "市区町村")]
        public string? City { get; set; }

        [Display(Name = "都道府県")]
        public string? State { get; set; }

        [Display(Name = "郵便番号")]
        public string? PostalCode { get; set; }

        [Display(Name = "電話番号")]
        public string? PhoneNumber { get; set; }
    }
}
