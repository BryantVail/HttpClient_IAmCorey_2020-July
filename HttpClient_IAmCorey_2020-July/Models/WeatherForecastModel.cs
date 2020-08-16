using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClient_IAmCorey_2020_July.Models
{


    public class WeatherForecastModel
    {
        public DayForecastModel[] Consolidated_weather { get; set; }
        public DateTime Sun_rise { get; set; } // sunRise (Json) => SunRise (C#)
        public DateTime Sun_set { get; set; }
        public string Title { get; set; }
        public string Timezone { get; set; }
    }

    


}
