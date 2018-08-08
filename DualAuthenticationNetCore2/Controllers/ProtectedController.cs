using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DualAuthenticationNetCore2.Controllers
{
    //When we use the Authorize attribute, it actually binds to the first authentication system by default
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("/api/customers")]
    public class ProtectedController:Controller
    {
        public ProtectedController()
        {

        }

        public IActionResult Get()
        {
            return Ok(new[] { "One", "Two", "Three" });
        }
    }
}
