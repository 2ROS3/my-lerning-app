using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weatheragregator.Models;

namespace Weatheragregator
{
    public class WeatherWebContent
    {
        private static readonly List<Weatherinformation> weatherInformationList = new List<Weatherinformation>
                {
                    new Weatherinformation{
                        Id = 1,
                        City = "Ivano-Frankivsk",
                        Date = DateTime.Today,
                        MinTemerature = 9,
                        MaxTemperature = 19,
                        WeatherType = "Sunny",
                    },
                    new Weatherinformation{
                        Id = 2,
                        City = "Ivano-Frankivsk",
                        Date = DateTime.Today.AddDays(1),
                        MinTemerature = 11,
                        MaxTemperature = 21,
                        WeatherType = "PartlyCloudy",
                    },
                };

    }
}
