using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EASA.Models
{
    public class CrewReq
    {
        public int Duration { get; set; }
        public int TaskCount { get; set; }
        public double AstronautCount { get; set; }

        public CrewReq(int duration, int taskCount)
        {
            Duration = duration;
            TaskCount = taskCount;
        }

        public double CalcAstronauts()
        {
            double tasksPerDay = (TaskCount / Duration);
            AstronautCount = Math.Ceiling(tasksPerDay / 40);
            return AstronautCount;
        }
    }
}
