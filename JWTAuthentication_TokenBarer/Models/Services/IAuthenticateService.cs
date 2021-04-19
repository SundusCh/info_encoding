using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Models.Services
{
    public interface IAuthenticateService
    {
        Student Authenticate(String UserName, String Password);
    }

}
