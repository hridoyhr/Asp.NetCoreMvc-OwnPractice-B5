using System;

namespace DependencyEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountManagementService = new AccountManagementService(
                new SpecialDatabaseAccessService());

            accountManagementService.CreateAccount("info@gmai.com", "12345");
        }
    }
}
