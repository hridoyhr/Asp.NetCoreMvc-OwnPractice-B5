﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyEx_1
{
    public interface IDatabaseAccessService
    {
        void DeleteUserAccount(string email);
        void SaveUserInDatabase(string email, string password);
        
    }
}
