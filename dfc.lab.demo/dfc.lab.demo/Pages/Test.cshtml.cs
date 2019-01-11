using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dfc.lab.demo.Pages
{
    public class TestModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "How to test the proposed solution";
        }
    }
}
