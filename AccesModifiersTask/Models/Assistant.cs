using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiersTask.Models
{
    internal class Assistant : Manager
    {
        private const string V = ":new salary";
        Employee employee = new Employee();
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccesfull)
            {
                GetPromotion(employee);
                Console.WriteLine(employee.Salary+V);

            }
            else
            {
                Console.WriteLine("ggk");
            }
        }

    }
}