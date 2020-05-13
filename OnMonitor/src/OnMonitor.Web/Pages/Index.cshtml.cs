﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace OnMonitor.Web.Pages
{
    public class IndexModel : OnMonitorPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}