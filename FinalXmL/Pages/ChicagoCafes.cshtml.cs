using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Cafe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalXmL.Pages
{
    public class ChicagoCafesModel : PageModel
    {
        public void OnGet()
        {
            string CafeJsonString = GetData("https://data.cityofchicago.org/resource/mqmh-p6ud.json");
            var allCafes = ChicagoCafe.FromJson(CafeJsonString);
            ViewData["allCafes"] = allCafes;
        }
        public string GetData(string endpoint)
        {
            string downloadedJson;
            using (WebClient webClient = new WebClient())
            {
                downloadedJson = webClient.DownloadString(endpoint);
            }
            return downloadedJson;
        }
    }
}