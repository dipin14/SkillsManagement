using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;
using Skillset_DAL.Repositories;
using Skillset_DAL.Models;

namespace Skillset_BLL.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository logRepository;
        public LoginService(ILoginRepository logRepo)
        {
            logRepository = logRepo;
        }
        public bool CheckStatus(LoginDTO lg)
        {
            Login log = new Login
            {
                UserName = lg.UserName,
                Password = lg.Password
            };
            var status=logRepository.CheckStatus(log);
            return status;
        }
        public string GetRole(string username)
        {
            var role=logRepository.GetRole(username);
            return role;

        }
    }
}
