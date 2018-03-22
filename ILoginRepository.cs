using stundent.webapi.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student.webapi.core.IRepositories
{
    public interface ILoginRepository
    {
        LoginStatus ValidateUser(string userName,string password);
        bool ValidateToken(string token);

    }
}
