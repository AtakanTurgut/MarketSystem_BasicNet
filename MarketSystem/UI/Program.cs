using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.Oracle;
using Entity.Concrete;

//IRealCustomerService realCustomerService = new RealCustomerManager(new RealCustomerDal());
IRealCustomerService realCustomerService = new RealCustomerManager(new OracleRealCustomerDal());
RealCustomer customer = new RealCustomer();
customer.Age = 23;      // <= 25
customer.Firstname = "Furkan";
customer.Lastname = "Üvenç";

realCustomerService.TAdd(customer);

RealCustomer customer2 = new RealCustomer();
customer2.Age = 28;      // <= 25
customer2.Firstname = "Yağmur";
customer2.Lastname = "Soydan";

realCustomerService.TAdd(customer2);

foreach (var item in realCustomerService.TGetAll())
{
    Console.WriteLine($"{item.Age} {item.Firstname} {item.Lastname}");
}

Console.WriteLine(new string('-', 10));

ICompanyService companyService = new CompanyManager(new CompanyDal());
Company company = new Company();
company.CompanyName = "ApiUiMvc";       // MvcApiUi
company.TaxNumber = "3629518";

companyService.TAdd(company);

Company company2 = new Company();
company2.CompanyName = "MvcUiApi";       // MvcApiUi
company2.TaxNumber = "7849513";

companyService.TAdd(company2);

foreach (var item in companyService.TGetAll())
{
    Console.WriteLine(item.TaxNumber + " " + item.CompanyName);
}