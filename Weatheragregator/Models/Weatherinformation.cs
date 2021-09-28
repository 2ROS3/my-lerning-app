using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weatheragregator.Models
{
    public class Weatherinformation
    {
       
        
            public int Id { get; set; }

            public int MinTemerature { get; set; }

            public int MaxTemperature { get; set; }

            public string City { get; set; }

            public DateTime Date { get; set; }

            public string WeatherType { get; set; }
            
            public IEnumerable WeatherInfoList { get; set; }
    }
}

