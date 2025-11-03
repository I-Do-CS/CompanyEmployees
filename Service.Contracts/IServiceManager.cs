namespace Service.Contracts;

public interface IServiceManager
{
    ICompanyService CompanyService { get; }
    IEmployeeService EmployeeService { get; }
    IAuthenticationSerivce AuthenticationSerivce { get; }
}
