using System.Collections.Generic;
using Common.DTO;
using Skillset_DAL.Models;

namespace Skillset_BLL.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<EmployeeDTO> GetAllEmployees();
        int AddNewEmployee(EmployeeDTO employee);
        EmployeeDTO EditEmployeeById(int id);
        int DeleteEmployeeById(int id);
        EmployeeDTO GetEmployeeDetailsById(int id);
        Employee MapDTOtoDBModel(EmployeeDTO dto);
        List<DesignationDTO> GetDesignations();
        List<QualificationDTO> GetQualifications();
        List<EmployeeDTO> GetManagers();
    }
}
