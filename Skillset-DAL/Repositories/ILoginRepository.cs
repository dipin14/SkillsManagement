using Skillset_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_DAL.Repositories
{
    public interface ILoginRepository
    {
        bool CheckStatus(Login lg);
        string GetRole(string username);
    }
}
