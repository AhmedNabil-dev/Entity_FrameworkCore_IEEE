using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_FrameWork_IEEE.Entities
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        // Foriegn Key 
        public int DepartmentID { get; set; }

        // Navigation Property
        public Department Department { get; set; }
     }
}
