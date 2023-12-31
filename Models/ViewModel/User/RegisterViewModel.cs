﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModel.User
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Рік народження")]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Поле {0} повинно мати минімум {2} і максимум {1} символ", MinimumLength = 6)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не співпадають")]
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердіть пароль")]
        public string PasswordConfirm { get; set; }
    }
}
