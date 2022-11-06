using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Respositories.entities
{
    class Bank
    {
        public int Bankid { get; set; }
        public int Name { get; set; }
        public List<Customer> customers { get; set; }
        public static List<Customer> Order(List<Customer> customers)       
        {
            List<Customer> temp=customers.OrderBy(c=>c.)
        }
    }
}
