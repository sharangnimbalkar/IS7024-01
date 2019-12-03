using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CountryData;
using FinalXmL.Models;
using Microsoft.AspNetCore.Mvc;
using MunicipalData;

namespace FinalXmL.Controller
{
    [Route("api/Geonamedata/[controller]")]
    [ApiController]
    public class MunicipalityJsonsController : ControllerBase
    {


        // GET: api/MunicipalityJsons
        [HttpGet]
        public ActionResult<IEnumerable<MunicipalityJson>> GetAirportJson()
        {
            List<MunicipalityJson> airportsOfRequiredCity = new List<MunicipalityJson>();
            string jsonString = GetData("https://pkgstore.datahub.io/core/country-list/data_json/data/8c458f2d15d9f2119654b29ede6e45b8/data_json.json");
            CountryCode[] country = CountryCode.FromJson(jsonString);

            string jsonString1 = GetData("https://pkgstore.datahub.io/core/world-cities/world-cities_json/data/5b3dd46ad10990bca47b04b4739a02ba/world-cities_json.json");
            Geonamedata[] geodata = Geonamedata.FromJson(jsonString1);

            foreach (Geonamedata geonamedata in geodata)
            {

                MunicipalityJson mj = new MunicipalityJson();
                mj.Country = geonamedata.Country;
                mj.Geonameid = geonamedata.Geonameid;
                mj.Name = geonamedata.Name;
                mj.Subcountry = geonamedata.Subcountry;
                airportsOfRequiredCity.Add(mj);

            }


            return airportsOfRequiredCity;
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