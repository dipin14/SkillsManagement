﻿using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_BLL.Services
{
    public interface ILoginService
    {
        bool CheckStatus(LoginDTO lg);
        string GetRole(string username);
    }
}