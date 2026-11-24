using Entity_FrameWork_IEEE.Data;
using Entity_FrameWork_IEEE.Entities;
using Microsoft.Identity.Client;
using System; 

namespace Entity_FrameWork_IEEE
{

    class Program
    {
        static void Main(string[] args)
        {

            var Dep1 = new Department
            {
                Name = "HR"
            };
            var Dep2 = new Department
            {
                Name = "IT_Support"
            };

            var emp1 = new Employee
            {
                Name = "Omer",
                PhoneNumber = "1234567890",
                DepartmentID = 1
            };

            var emp2 = new Employee
            {
                ID = 2,
                Name = "Mona",
                PhoneNumber = "1234964640",
                DepartmentID = 1

            };

          using var Context = new AplicationDbContext() ;

            //Context.Departments.Add(Dep1 ) ;
            //Context.Departments.Add(Dep2 ) ;

            //Context.Employees.Add(emp1);
            //Context.Employees.Add(emp2);

            //Context.Employees.Update(emp2);

            Context.Employees.Remove(emp2);

            Context.SaveChanges();

            //Context.Dispose();   
                
       }

    }

}
