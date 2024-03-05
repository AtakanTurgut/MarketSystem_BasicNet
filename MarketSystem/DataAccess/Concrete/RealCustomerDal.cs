using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RealCustomerDal : IRealCustomerDal
    {
        private readonly List<RealCustomer> _realCustomers;

        public RealCustomerDal()
        {
            _realCustomers = new List<RealCustomer> 
            { 
                new RealCustomer { RealCustomerId = 1, Firstname = "Atakan", Lastname = "Turgut", Age = 22, Phone = "5430000000", NationalId = "123456789" }             
            };
        }

        public void Add(RealCustomer realCustomer)
        {
            _realCustomers.Add(realCustomer);
        }

        public List<RealCustomer> GetAll()
        {
            return _realCustomers;
        }
    }
}
