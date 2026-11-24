using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_FrameWork_IEEE.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        //Navigation ProPerty 
        public ICollection<Employee> Employees { get; set; }
    }
}
