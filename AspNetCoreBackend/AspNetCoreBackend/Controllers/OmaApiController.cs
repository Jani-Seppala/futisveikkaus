﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackend.Controllers
{
    [Route("api/oma")]
    [ApiController]
    public class OmaApiController : ControllerBase
    {
        [Route("luku")]
        public int Luku()
        {
            return 123;
        }

        [Route("merkkijono")]
        public string Merkkijono()
        {
            return "tietokone";
        }

        [Route("merkkijonot")]
        public string[] Merkkijonot()
        {
            return new string[] { "tietokone", "näyttö", "näppäimistö" };
        }


        [Route("satunnainen")]
        public int Satunnaisluku()
        {
            Random random = new Random();
            int luku = random.Next(1, 20);
            return luku;




        }
    }
}  
