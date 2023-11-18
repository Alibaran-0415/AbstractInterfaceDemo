using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Adapters;
using AbstractInterfaceDemo.Concrete;
using AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager2.Save(new Customer { DateOfBirth = new DateTime(1980, 4, 4), FirstName = "Doğukan", LastName = "Özcan", NationalityId = "5959564519546" });
            Console.ReadLine();
        }
    }
}
