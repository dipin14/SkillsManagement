using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_DAL.Repositories
{
    public interface IEmployeeSkill
    {
        string GetEmployeeDetails(string option, string searchKey);
        string GetDesignationDetails(string option, string searchKey);
    }
}
