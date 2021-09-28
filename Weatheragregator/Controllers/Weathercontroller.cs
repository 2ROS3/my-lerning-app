using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weatheragregator.Models;





   class Weathercontroller
    {
    private IEnumerable<Weatherinformation> weatherInfoList;


    
        [HttpGet]
        public IEnumerable<Weatherinformation> Get()
        {
            return weatherInfoList;
        }

       

      
    }



