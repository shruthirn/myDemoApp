using System.Collections.Generic;

namespace myDemoApp.API.Models
{
    public class EmployeeData
    {
          public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }

        public string Designation { get; set; }

        public string DOB { get; set; }

       // public ICollection<Photo> Photos { get; set; }
       public string Url { get; set; }

    }
}