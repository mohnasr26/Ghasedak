﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ghasedak.Models
{
    public class Box
    {
        public int id { get; set; }
        [Display(Name = "شماره ")]
        [MaxLength(10, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string number { get; set; }

        [Display(Name = "نام و نام خانوادگی ")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string fullName { get; set; }

        [Display(Name = "موبایل ")]
        [MaxLength(11, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [MinLength(11, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string mobile { get; set; }

        [Display(Name = "تاریخ واگذاری ")]
        [MaxLength(30, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string assignmentDate { get; set; }

        [ForeignKey("dischargeRoute")]
        public int dischargeRouteId { get; set; }
        public virtual DischargeRoute dischargeRoute { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
         [Display(Name = "آدرس ")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string address { get; set; }
    }
}