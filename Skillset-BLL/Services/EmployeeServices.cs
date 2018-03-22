using System;
using System.Collections.Generic;
using Common.DTO;
using Skillset_DAL.Models;
using Skillset_DAL.Repositories;

namespace Skillset_BLL.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private IEmployeeRepository _repository;

        public EmployeeServices(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public Employee MapDTOtoDBModel(EmployeeDTO dto)
        {
            Employee employee = new Employee();
            employee.EmployeeCode = dto.EmployeeCode;
            employee.Name = dto.Name;
            employee.DateOfBirth = dto.DateOfBirth;
            employee.DateOfJoining = dto.DateOfJoining;
            employee.DesignationId =Convert.ToInt32(dto.DesignationId);
            employee.Experience = dto.Experience;
            employee.QualificationId = Convert.ToInt32(dto.QualificationId);
            employee.Address = dto.Address;
            employee.MobileNumber = dto.MobileNumber;
            employee.Email = dto.Email;
            employee.Gender = dto.Gender;
            employee.ManagerCode = dto.ManagerCode;
            return employee;
        }
        public int AddNewEmployee(EmployeeDTO employee)
        {
           return _repository.AddEmployee(MapDTOtoDBModel(employee));
           
           
        }

        public int DeleteEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO EditEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO GetEmployeeDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public List<DesignationDTO> GetDesignations()
        {
            var list = _repository.GetDesignations();
            var dto = new List<DesignationDTO>();
            int count = 0;
            foreach(Designation item in list)
            {
                dto[count].Id = item.Id;
                dto[count].Name = item.Name;
                count++;
            }
            return dto;
        }

        public List<QualificationDTO> GetQualifications()
        {
            var list = _repository.GetQualifications();
            var dto = new List<QualificationDTO>();
            int count = 0;
            foreach (Qualification item in list)
            {
                dto[count].Id = item.Id;
                dto[count].Name = item.Name;
                count++;
            }
            return dto;
        }

        public List<EmployeeDTO> GetManagers()
        {
            var list = _repository.GetManagers();
            var dto = new List<EmployeeDTO>();
            int count = 0;
            foreach (Employee item in list)
            {
                dto[count].EmployeeCode = item.EmployeeCode;
                dto[count].Name = item.Name;
                count++;
            }
            return dto;
        }
    }
}
