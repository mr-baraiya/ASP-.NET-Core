using Newtonsoft.Json;

namespace JSONSerealizedAndDeSerealizedDemo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        [JsonRequired]
        public string LastName { get; set; }

        public string Email { get; set; }

        [JsonIgnore]
        public String PhoneNumber { get; set; }

        public bool isActive { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

    }
}
