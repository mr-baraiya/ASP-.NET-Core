using StudentBlazorApp.Models;

namespace StudentBlazorApp.Services
{
    public class StudentService
    {
        private readonly HttpClient _httpClient;

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Student>?> GetStudents()
        {
            return await _httpClient.GetFromJsonAsync<List<Student>>("https://localhost:7006/api/Student");
        }

    }
}
