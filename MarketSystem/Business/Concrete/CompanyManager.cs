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
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void TAdd(Company company)
        {
            if (company.CompanyName == "ApiUiMvc")
            {
                Console.WriteLine("%10 indirim uygulandı.");
            }
            else
            {
                Console.WriteLine("Uygun şirket değil.");
            }

            _companyDal.Add(company);
        }

        public List<Company> TGetAll()
        {
            return _companyDal.GetAll();
        }
    }
}
