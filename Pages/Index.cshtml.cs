﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Web;

namespace FrontDoorCDN.Pages
{    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public DateTime myDate;

        public IndexModel(ILogger<IndexModel> logger)
        {
           
           myDate = System.DateTime.Now;
           _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
