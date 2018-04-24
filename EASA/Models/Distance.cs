using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EASA.Models
{
    public class Distance
    {
        public double Lat1 { get; set; }
        public double Long1 { get; set; }
        public double Lat2 { get; set; }
        public double Long2 { get; set; }

        public Distance(double lat1Degrees, double lat1Minutes, double long1Degrees, double long1Minutes, double lat2Degrees, double lat2Minutes, double long2Degrees, double long2Minutes)
        {
            double lat1TotalDegrees = lat1Degrees + (lat1Minutes / 60);
            Lat1 = lat1TotalDegrees * (Math.PI / 180);
            double long1TotalDegrees = long1Degrees + (long1Minutes / 60);
            Long1 = long1TotalDegrees * (Math.PI / 180);

            double lat2TotalDegrees = lat2Degrees + (lat2Minutes / 60);
            Lat2 = lat2TotalDegrees * (Math.PI / 180);
            double long2TotalDegrees = long2Degrees + (long2Minutes / 60);
            Long2 = long2TotalDegrees * (Math.PI / 180);
        }

        public double CalcDistance()
        {
            double result = 2 * 6367.4445 * Math.Asin(Math.Pow((Math.Pow(Math.Sin((Lat2 - Lat1) / 2), 2) + Math.Cos(Lat1) * Math.Cos(Lat2) * Math.Pow(Math.Sin((Long2 - Long1) / 2), 2)), .5));
            return result;
        }

        public double ConvertNautical(double kilometers)
        {
            double result = kilometers * 0.53996;
            return result;
        }
    }
}
