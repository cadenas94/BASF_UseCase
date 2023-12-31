﻿using BASF_UseCase.Entities;
using System.ComponentModel.DataAnnotations;

namespace BASF_UseCase.Models
{
    public class MaterialViewModel : Material
    {
        [Display(Name = "Material")]
        public string MaterialValue { get; set; }
        
        public decimal Quantity { get; set; }
    }
}
