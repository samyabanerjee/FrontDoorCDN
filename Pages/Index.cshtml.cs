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
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration=0)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
