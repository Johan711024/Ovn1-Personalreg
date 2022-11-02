namespace Ovn1_Personalreg
{
    internal class Program
    {
        static StaffList staffList = new StaffList();

        static void Main(string[] args)
        {
            SeedData();
            
            do 
            {
                ShowMenu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":

                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);
        }
        private static void PrintEmployees()
        {
            List<Employee> employees = staffList.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            
        }
        private static void ShowMenu()
        {
            Console.WriteLine("1. add employee");
            Console.WriteLine("2. print employee");
            Console.WriteLine("Q. quit");
        }
        private static void SeedData()
        {
            staffList.AddEmployee("Otto", 24000);
            staffList.AddEmployee("Sara", 32000);
        }
    }
}