﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cato
{
    [DataContract]
    class WeatherData
    {
        [DataMember]
        public string Cod { get; set; }
        [DataMember]
        public double Message { get; set; }
        [DataMember]
        public int Cnt { get; set; }
        [DataMember]
        public List<List> List { get; set; }
        [DataMember]
        public City City { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
        public double Pressure { get; set; }
        public double Sea_level { get; set; }
        public double Grnd_level { get; set; }
        public int Humidity { get; set; }
        public double Temp_kf { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Clouds
    {
        public int All { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public double Deg { get; set; }
    }

    public class Snow
    {
        public double? __invalid_name__3h { get; set; }
    }

    public class Sys
    {
        public string Pod { get; set; }
    }

    public class List
    {
        public int Dt { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Snow Snow { get; set; }
        public Sys Sys { get; set; }
        public string Dt_txt { get; set; }
    }

    public class Coord
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
    }

}
