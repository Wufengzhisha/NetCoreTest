using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoveController : ControllerBase
    {

        /// <summary>
        /// post
        /// </summary>
        /// <param name="love">model实体类参数</param>
        [HttpPost]
        public void Post(Love love)
        {
        }
    }
}
