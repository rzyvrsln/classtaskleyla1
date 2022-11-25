namespace AccesModifiersTask.Models
{
    internal class Manager
    {
       protected Employee GetPromotion(Employee employee)
        {

            employee.Salary += 100;
            return employee;
        }   
    } 
   
}
