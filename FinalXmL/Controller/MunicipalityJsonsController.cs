using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalXmL.Models;
using CountryData;
using MunicipalData;
using System.Net;

namespace FinalXmL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class MunicipalityJsonsController : ControllerBase
    {

        // GET: api/MunicipalityJsons
        [HttpGet]
        public ActionResult<IEnumerable<MunicipalityJson>> GetMunicipalityJson()
        {
            List<MunicipalityJson> municipalityrequired = new List<MunicipalityJson>();
            string jsonString = GetData("https://pkgstore.datahub.io/core/country-list/data_json/data/8c458f2d15d9f2119654b29ede6e45b8/data_json.json");
            CountryCode[] country = CountryCode.FromJson(jsonString);

            string jsonString1 = GetData("https://pkgstore.datahub.io/core/world-cities/world-cities_json/data/5b3dd46ad10990bca47b04b4739a02ba/world-cities_json.json");
            Geonamedata[] geodata = Geonamedata.FromJson(jsonString1);

            foreach (Geonamedata gdata in geodata)
            {

                MunicipalityJson mj = new MunicipalityJson();
                mj.Countries = gdata.Country;
                mj.Geonameids = gdata.Geonameid;
                mj.Names = gdata.Name;
                mj.Subcountries = gdata.Subcountry;
                municipalityrequired.Add(mj);

            }


            return municipalityrequired;
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
