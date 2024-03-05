using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RealCustomerManager : IRealCustomerService
    {
        private readonly IRealCustomerDal _realCustomerDal;

        public RealCustomerManager(IRealCustomerDal realCustomerDal)
        {
            _realCustomerDal = realCustomerDal;
        }

        public void TAdd(RealCustomer realCustomer)
        {
            if (realCustomer.Age <= 25)
            {
                Console.WriteLine("%5 indirim uygulandı.");
            }
            else
            {
                Console.WriteLine("Yaş 25'den büyük.");
            }

            _realCustomerDal.Add(realCustomer);
        }

        public List<RealCustomer> TGetAll()
        {
            return _realCustomerDal.GetAll();
        }
    }
}
