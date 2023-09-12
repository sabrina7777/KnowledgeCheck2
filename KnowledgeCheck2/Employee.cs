using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Employee
    {
        public string? FirstName;
        public string? LastName;
        public string? Department;
        public int YearsService;

        public void Greeting()
        {
            Console.WriteLine("Hi " + FirstName + " from " + Department);
        }

    }
}
