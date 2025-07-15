using ConsumeAPIDemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ConsumeAPIDemoProject.Controllers
{
    public class UserController : Controller
    {
        private string url = "http://localhost:5292/api/V1/User/";
        private readonly HttpClient client = new HttpClient();

        #region GetAllUser
        [HttpGet]
        public IActionResult Index()
        {
            List<User> users = new List<User>();
            try
            {
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
                else
                {
                    TempData["ErrorMessage"] = "Failed to fetch users.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while fetching users: " + ex.Message;
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
                TempData["ErrorMessage"] = "An unexpected error occurred: " + ex.Message;
            }

            return View(u);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            User u = new User();
            try
            {
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
                else
                {
                    TempData["ErrorMessage"] = "Failed to load user data.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while loading user: " + ex.Message;
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
                    TempData["ErrorMessage"] = "Failed to update user.";
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
            try
            {
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
                else
                {
                    TempData["ErrorMessage"] = "User not found.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while loading details: " + ex.Message;
            }

            return View(u);
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            User u = new User();
            try
            {
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
                else
                {
                    TempData["ErrorMessage"] = "User not found.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while loading user: " + ex.Message;
            }
            return View(u);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync(url + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["DeleteMessage"] = "User Deleted Successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = "Failed to delete user.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting user: " + ex.Message;
            }

            return RedirectToAction("Index");
        }
        #endregion

    }
}
