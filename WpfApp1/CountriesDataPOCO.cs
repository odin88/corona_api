using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    public class CountriesDataPOCO
    {

        public class Rootobject
        {
            public bool success { get; set; }
            public Result[] result { get; set; }
        }

        public class Result
        {
            public string country { get; set; }
            public string totalCases { get; set; }
            public string newCases { get; set; }
            public string totalDeaths { get; set; }
            public string newDeaths { get; set; }
            public string totalRecovered { get; set; }
            public string activeCases { get; set; }
        }

    }
}
