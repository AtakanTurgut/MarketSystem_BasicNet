using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Oracle
{
    public class OracleRealCustomerDal : IRealCustomerDal
    {
        private readonly List<RealCustomer> _realCustomers;

        public OracleRealCustomerDal()
        {
            _realCustomers = new List<RealCustomer>
            {
                new RealCustomer { RealCustomerId = 1, Firstname = "Oracle", Lastname = "Turgut", Age = 22, Phone = "5430000000", NationalId = "123456789" }
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
