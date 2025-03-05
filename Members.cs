using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class Members
    {
        [DisplayName("賬號")]
        [Required(ErrorMessage = "請輸入賬號")]
        [StringLength(30, MinimumLength = 6,ErrorMessage = "賬號長度須介於6-30字元")]
        [Remote("AccountCheck","Members",ErrorMessage ="此賬號已被注冊過")]
        public string Account { get; set; }

        public string Password { get; set; }

        [DisplayName("姓名")]
        [Required(ErrorMessage = "請輸入姓名")]
        [StringLength(20, ErrorMessage = "姓名不超過20字元")]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "請輸入Email")]
        [StringLength(200, ErrorMessage = "Email最多200字元")]
        [EmailAddress(ErrorMessage ="這不是Email格式")]
        public string Email { get; set; }

        public string AuthCode { get; set; }

        public bool IsAdmin { get; set; }
    }
}