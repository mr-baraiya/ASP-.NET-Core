using CityCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CityCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        #region configuration
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            string connectionstr = this._configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connectionstr);

            int cityCount = 0, stateCount = 0, countryCount = 0;
            SqlCommand cmdCount = new SqlCommand("PR_LOC_GetCounts", conn);
            cmdCount.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader countReader = cmdCount.ExecuteReader();
            if (countReader.Read())
            {
                countryCount = Convert.ToInt32(countReader["CountryCount"]);
                stateCount = Convert.ToInt32(countReader["StateCount"]);
                cityCount = Convert.ToInt32(countReader["CityCount"]);
            }
            conn.Close();

            ViewBag.CountryCount = countryCount;
            ViewBag.StateCount = stateCount;
            ViewBag.CityCount = cityCount;

            return View();
        }
        #endregion

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
