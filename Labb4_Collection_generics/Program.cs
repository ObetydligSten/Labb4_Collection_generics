
// SUT23 Rasmus Glasell Johansson

namespace Labb4_Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Del 1
            Employee em1 = new Employee()
            {
                Id = 101,
                Name = "Stefan",
                Gender = "Male",
                Salary = 38000
            };
            Employee em2 = new Employee()
            {
                Id = 102,
                Name = "Michael",
                Gender = "Male",
                Salary = 28000
            };
            Employee em3 = new Employee()
            {
                Id = 103,
                Name = "Jon",
                Gender = "Male",
                Salary = 44000
            };
            Employee em4 = new Employee()
            {
                Id = 104,
                Name = "Miriam",
                Gender = "Female",
                Salary = 26000
            };
            Employee em5 = new Employee()
            {
                Id = 105,
                Name = "Lisa",
                Gender = "Female",
                Salary = 41000
            };

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(em1);
            employeeStack.Push(em2);
            employeeStack.Push(em3);
            employeeStack.Push(em4);
            employeeStack.Push(em5);

            
            //Writing every element in stack
            foreach (Employee e in employeeStack)
            {                
                Console.WriteLine($"{e.Id} - {e.Name} - {e.Gender} - {e.Salary}" +
                    $"\nItems left in stack : {employeeStack.Count}");                
            }
            Console.WriteLine("---------------------------");

            //Pop-method
            while (employeeStack.Count > 0)
            {
                Employee emPop = employeeStack.Pop();
                Console.WriteLine($"{emPop.Id} - {emPop.Name} - {emPop.Gender} - {emPop.Salary}" +
                    $"\nItems left in stack : {employeeStack.Count}");               
            }
            Console.WriteLine("---------------------------");

            employeeStack.Push(em1);
            employeeStack.Push(em2);
            employeeStack.Push(em3);
            employeeStack.Push(em4);
            employeeStack.Push(em5);

            Employee emPeek1 = employeeStack.Peek();
            Employee emPeek2 = employeeStack.Peek();

            Console.WriteLine($"{emPeek1.Id} - {emPeek1.Name} - {emPeek1.Gender} - {emPeek1.Salary}" +
                    $"\nItems left in stack : {employeeStack.Count}");
            Console.WriteLine($"{emPeek2.Id} - {emPeek2.Name} - {emPeek2.Gender} - {emPeek2.Salary}" +
                    $"\nItems left in stack : {employeeStack.Count}");
            Console.WriteLine("---------------------------");

            bool exists = employeeStack.Contains(em3);
            if (exists)
            {
                Console.WriteLine("em3 exists in the stack\n");
            }
            else
            {
                Console.WriteLine("em3 does not exist in the stack\n");
            }


            //Del 2

            List<Employee> emList = new List<Employee>();

            emList.Add(em1);
            emList.Add(em2);
            emList.Add(em3);
            emList.Add(em4);
            emList.Add(em5);

            bool listExist = emList.Contains(em2);
            if (listExist)
            {
                Console.WriteLine("em2 object exists in the list\n");
            }
            else
            {
                Console.WriteLine("em2 object does not exist in the list\n");
            }

            Employee re = emList.Find(e => e.Gender == "Male");
            Console.WriteLine($"{re.Id} - {re.Name} - {re.Gender} - {re.Salary}\n");

            List<Employee> reList = emList.FindAll(e => e.Gender == "Male");
            foreach (Employee e in reList)
            {
                Console.WriteLine($"{e.Id} - {e.Name} - {e.Gender} - {e.Salary}");
            }

            Console.ReadKey();
        }
    }
}