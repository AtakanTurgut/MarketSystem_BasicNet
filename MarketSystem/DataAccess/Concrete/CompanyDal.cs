using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CompanyDal : ICompanyDal
    {
        private readonly List<Company> _companies;

        public CompanyDal()
        {
            _companies = new List<Company>
            {
                new Company { CompanyId = 1, CompanyName = "UiApiMvc", Phone = "5510000000", TaxNumber = "8462159" } 
            };
        }

        public void Add(Company company)
        {
            _companies.Add(company);
        }

        public List<Company> GetAll()
        {
            return _companies;
        }
    }
}
