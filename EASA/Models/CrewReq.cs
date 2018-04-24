using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EASA.Models
{
    public class CrewReq
    {
        public double Duration { get; set; }
        public double AstronautCount { get; set; }
        public int TaskCount { get; set; }

        public CrewReq(double duration, int taskCount)
        {
            Duration = duration;
            TaskCount = taskCount;
        }

        public double CalcAstronauts()
        {
            double tasksPerHour = (TaskCount / 4);
            double hours = (Duration * .66);
            AstronautCount = Math.Ceiling(tasksPerHour / hours);
            return AstronautCount;
        }
    }
}
