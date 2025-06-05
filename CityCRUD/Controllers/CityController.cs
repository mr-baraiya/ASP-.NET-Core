using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using CityCRUD.Models;

namespace CityCRUD.Controllers
{
    public class CityController : Controller
    {
        private readonly IConfiguration _configuration;

        #region configuration
        public CityController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            string connectionstr = this._configuration.GetConnectionString("DefaultConnection");
            //PrePare a connection
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstr);
            conn.Open();

            //Prepare a Command
            SqlCommand objCmd = conn.CreateCommand();
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "PR_LOC_City_SelectAll";

            SqlDataReader objSDR = objCmd.ExecuteReader();
            dt.Load(objSDR);
            conn.Close();
            return View("Index", dt);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int CityID)
        {
            string connectionstr = _configuration.GetConnectionString("DefaultConnection");
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                using (SqlCommand sqlCommand = conn.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "PR_LOC_City_Delete";
                    sqlCommand.Parameters.AddWithValue("@CityID", CityID);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            return RedirectToAction("Index");
        }
        #endregion

        #region AddEdit (GET)
        public IActionResult CityAddEdit(int? CityID)
        {
            string connectionstr = _configuration.GetConnectionString("DefaultConnection");
            CityModel model = new CityModel();

            if (CityID != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionstr))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "PR_LOC_City_SelectByPK";
                    cmd.Parameters.AddWithValue("@CityID", CityID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        model.CityID = Convert.ToInt32(reader["CityID"]);
                        model.CityName = reader["CityName"].ToString();
                        model.CountryID = Convert.ToInt32(reader["CountryID"]);
                        model.StateID = Convert.ToInt32(reader["StateID"]);
                    }
                }
            }

            return View("CityAddEdit", model);
        }
        #endregion

        #region Save (POST)
        [HttpPost]
        public IActionResult Save(CityModel model)
        {
            if (!ModelState.IsValid)    
            {
                return View("CityAddEdit", model);
            }

            string connectionstr = _configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                if (model.CityID == 0)
                {
                    cmd.CommandText = "PR_LOC_City_Insert";
                }
                else
                {
                    cmd.CommandText = "PR_LOC_City_Update";
                    cmd.Parameters.AddWithValue("@CityID", model.CityID);
                }

                cmd.Parameters.AddWithValue("@CityName", model.CityName);
                cmd.Parameters.AddWithValue("@CountryID", model.CountryID);
                cmd.Parameters.AddWithValue("@StateID", model.StateID);

                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region CountryDropDown
        public void CountryDropDown()
        {
            try
            {
                string connectionString = this._configuration.GetConnectionString("DefaultConnection");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "PR_LOC_Country_Fill_Dropdown";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            List<CountryDropDownModel> CountryList = new List<CountryDropDownModel>();
                            foreach (DataRow data in dataTable.Rows)
                            {
                                CountryDropDownModel model = new CountryDropDownModel();
                                model.CountryID = Convert.ToInt32(data["CountryID"]);
                                model.CountryName = data["CountryName"].ToString();
                                CountryList.Add(model);
                            }
                            ViewBag.CountryList = CountryList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while fetching country: " + ex.Message;
            }
        }
        #endregion

        #region CountryDropDown
        public void StateDropDown()
        {
            try
            {
                string connectionString = this._configuration.GetConnectionString("DefaultConnection");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "PR_LOC_State_Fill_Dropdown";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            List<StateDropDownModel> StateList = new List<StateDropDownModel>();
                            foreach (DataRow data in dataTable.Rows)
                            {
                                StateDropDownModel model = new StateDropDownModel();
                                model.StateID = Convert.ToInt32(data["StateID"]);
                                model.StateName = data["StateName"].ToString();
                                StateList.Add(model);
                            }
                            ViewBag.StateList = StateList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while fetching State: " + ex.Message;
            }
        }
        #endregion
    }
}

