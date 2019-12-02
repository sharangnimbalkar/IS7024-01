﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalXmL.Pages
{
    public class CrimeSurveysModel : PageModel
    {
        public CrimeSurvey[] crimeSurveys;
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {


                string crimeSurveyString = webClient.DownloadString("https://smartenrollmentforcrimeresolution.azurewebsites.net/api/CrimeSurveys");
                crimeSurveys = CrimeSurvey.FromJson(crimeSurveyString);
                ViewData["crimeSurveys"] = crimeSurveys;

            }

        }
    }
}