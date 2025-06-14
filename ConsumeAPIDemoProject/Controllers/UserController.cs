using ConsumeAPIDemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ConsumeAPIDemoProject.Controllers
{
    public class UserController : Controller
    {
        private string url = "http://localhost:5292/api/User/";
        private HttpClient client = new HttpClient();

        #region GetAllUser
        [HttpGet]
        public IActionResult Index()
        {
            List<User> users = new List<User>();
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<User>>(result);
                if (data != null)
                {
                    users = data;
                }
            }
            return View(users);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User u)
        {
            try
            {
                string data = JsonConvert.SerializeObject(u);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    TempData["InsertMessage"] = "User Registered Successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = "Failed to register user. Server returned an error.";
                }
            }
            catch (Exception ex)
            {
                // Log the exception here (e.g., to a file or database if needed)
                TempData["ErrorMessage"] = "An unexpected error occurred: " + ex.Message;
            }

            return View(u); // Return the view with user data to preserve form inputs
        }

        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Edit(int id)
        {
            User u = new User();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<User>(result);
                if (data != null)
                {
                    u = data;
                }
            }
            return View(u);
        }

        [HttpPost]
        public IActionResult Edit(User u)
        {
            try
            {
                string data = JsonConvert.SerializeObject(u);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PutAsync(url + u.userId, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    TempData["UpdateMessage"] = "User Updated Successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = "Failed to Update user. Server returned an error.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An unexpected error occurred: " + ex.Message;
            }

            return View(u);
        }
        #endregion

        #region Details
        [HttpGet]
        public IActionResult Details(int id)
        {
            User u = new User();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<User>(result);
                if (data != null)
                {
                    u = data;
                }
            }
            return View(u);
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            User u = new User();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<User>(result);
                if (data != null)
                {
                    u = data;
                }
            }
            return View(u);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            HttpResponseMessage response = client.DeleteAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["DeleteMessage"] = "User Deleted Successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion
    }
}
