using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyEx_1
{
    public class AccountManagementService
    {
        private IDatabaseAccessService _databaseAccessService;
        public AccountManagementService(IDatabaseAccessService databaseAccessService)
        {
            _databaseAccessService = databaseAccessService;
        }
        public void CreateAccount(string email, string password)
        {
            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                _databaseAccessService.SaveUserInDatabase(email, password);
                try
                {
                    var emilService = new EmailService();
                    emilService.SendEmailToUser(email);
                }
                catch(Exception ex)
                {
                    _databaseAccessService.DeleteUserAccount(email);
                }
            }
        }
    }
}
