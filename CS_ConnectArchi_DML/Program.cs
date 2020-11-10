using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConnectArchi_DML
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess ds = new DataAccess();
            var departments = ds.GetDepartments();
            // print all departments
            Console.WriteLine("List of Records in Dept Table");
            foreach (var item in departments)
            {
                Console.WriteLine($"{item.DeptNo} {item.DeptName} {item.Location} {item.Capacity}");
            }

            Console.WriteLine();
            Console.WriteLine("Adding New Record");
            var dept = new Dept()
            {
                 DeptNo = 90, DeptName = "Marketing", Location="Mumbai", Capacity=50
            };
            // passing the dept object to create new department
            // ds.AddDept(dept);


            // Update the record
            //            ds.UpdateDept(dept.DeptNo, dept);
            ds.DeleteDept(dept.DeptNo);

            Console.ReadLine();
        }
    }
}
