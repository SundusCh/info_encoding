using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;


namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
public class MobileController : ControllerBase
{
        private readonly List<Mobile> Mobiles = new List<Mobile>()
{
new Mobile { id = 1, brand = "samsung", model = "Galaxy Note 20", price= 80000},
new Mobile { id = 2, brand = "apple", model = "IPhone XS", price= 100000},
new Mobile { id = 3, brand = "mi", model = "note9", price= 9500},
new Mobile { id = 4, brand = "vivo", model = "v6", price= 10000},
new Mobile { id = 5, brand = "BLACKBERRY", model = "Curve9360", price= 10000},

};

        private readonly ILogger<MobileController> _logger;
public MobileController(ILogger<MobileController> logger)
{
_logger = logger;
}
[HttpGet]
        public IEnumerable<Mobile> Get()
        {
            return Mobiles;
        }
        [HttpGet("{id:int}")]
        public Mobile GetOne(int id)
        {
            return Mobiles.SingleOrDefault(x => x.id ==id);
        }

    }
}