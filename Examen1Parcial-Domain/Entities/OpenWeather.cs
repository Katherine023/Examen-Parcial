﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Entities.City;

namespace Domain.Entities
{
    public class OpenWeather
    {

        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

        public class Main
        {
            public double Temp { get; set; }
            public double Feels_like { get; set; }
            public double Temp_min { get; set; }
            public double Temp_max { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public int Sea_level { get; set; }
            public int Grnd_level { get; set; }
        }
    }
    public class Sys
    {
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }

}