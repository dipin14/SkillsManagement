using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_BLL.Services
{
    public interface IEmployeeSkillService
    {
        IEnumerable<TelephoneDirectoryRecordDTO> ViewSearchedRecords(string employeeCodeSearch,string employeeNameSearch,string designationSearch);
    }
}
