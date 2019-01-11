﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dfc.lab.demo.Pages
{
    public class CurrentModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "How the CI/CD pipeline is set up currently";
        }
    }
}
