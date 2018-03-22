using student.webapi.core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samplewebapi.Filter
{
    public class AuthTokenVerify
    {
        private ILoginRepository _loginRepository;
        public AuthTokenVerify(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public dynamic VerifyAuthToken(string authHeader)
        {
            bool isValid = false;

            if (authHeader != null)
            {
                var response = _loginRepository.ValidateToken(authHeader);
                return response;

            }
            return isValid;
        }
    }
}