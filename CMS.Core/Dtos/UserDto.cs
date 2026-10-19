using CMS.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS.Core.Dtos
{
    public class UserDto
    {
        public string? Id { get; set; }
        [Display(Name ="اسم المستخدم")]
        public string FullName { get; set; }
        [Display(Name = "البريد الالكتروني")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "رقم الجوال")]
        public string PhoneNumber { get; set; }
        [Display(Name = "الصورة")]
        public IFormFile? Image { get; set; }
        [Display(Name = "تاريخ الميلاد")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }
        [Display(Name = "نوع المستخدم")]
        public UserType UserType { get; set; }
    }
}
