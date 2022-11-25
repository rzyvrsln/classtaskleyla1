using AccesModifiersTask.Models;

namespace AccesModifiersTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Elxan", true, 350);
            Assistant assistant = new Assistant();
              


        assistant.GetFeedBack(employee);
        }
    }
}