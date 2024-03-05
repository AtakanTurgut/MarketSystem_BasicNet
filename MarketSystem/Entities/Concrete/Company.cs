using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Company : BaseCustomer, IEntity
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxNumber { get; set; }
    }
}
