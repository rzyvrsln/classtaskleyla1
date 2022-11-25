using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiersTask.Models
{
    internal class Employee
    {
        string _name;
        bool _isSuccesful;
        float _salary;
       
        public string Name  { get; set; }
        public bool IsSuccesfull { get; set; }
        public float Salary { get; set; }


        public Employee(string Name, bool IsSuccesfull ,float Salary)
        {
            this.Name = Name;
           this. IsSuccesfull = IsSuccesfull;    
            this.Salary = Salary;    
        }

        public Employee()
        {

        }
    }
}
