﻿using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class HeaderVM
    {
        public IEnumerable<ProductCategory> Categories { get; set; }
    }
}
