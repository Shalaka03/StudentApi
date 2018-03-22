using student.webapi.core.IRepositories;
using System;
using stundent.webapi.core.Models;
using System.Linq;

namespace student.webapi.data.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public bool ValidateToken(string token)
        {
            using (var _context = new SchoolDbContext())
            {
                var isTokenValid = _context.UserDetails.Any(user => user.Token.Equals(token));
                return isTokenValid;
            }
        }

        public LoginStatus ValidateUser(string userName, string password)
        {
            var loginStatus = default(LoginStatus);
            using (var _context = new SchoolDbContext())
            {
                var userDetail = _context.UserDetails.Where(user => user.UserName.Equals(userName,StringComparison.OrdinalIgnoreCase) && user.UserPassword.Equals(password,StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (userDetail != null)
                {
                    loginStatus = new LoginStatus();
                    var token = Guid.NewGuid().ToString();
                    userDetail.Token = token;
                    _context.SaveChanges();
                    loginStatus.status = true;
                    loginStatus.token = token;
                }
                return loginStatus;
            }
        }
    }
}
