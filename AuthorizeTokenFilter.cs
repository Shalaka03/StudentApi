using student.webapi.core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Samplewebapi.Filter
{
    public class AuthorizeTokenFilter : AuthorizationFilterAttribute
    {

        private const string AUTHORIZATION = "Authorization";
        AuthTokenVerify authTokenVerify = null;
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                var authHeader = actionContext.Request.Headers.Authorization.Parameter;
                //Get the instance of the repository using the dependancy resolver 
                var _loginRepository = (ILoginRepository)actionContext.RequestContext.Configuration.DependencyResolver.GetService(typeof(ILoginRepository));

                authTokenVerify = new AuthTokenVerify(_loginRepository);
                if (!authTokenVerify.VerifyAuthToken(authHeader))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid token");
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}
