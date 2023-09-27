using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_app
{
    internal class Attendance
    {  
        public int TimeIn { get; set; }
        public int TimeOut { get; set; }

        public Attendance(int timeIn, int timeOut)
        {
            TimeIn = timeIn;
            TimeOut = timeOut;
        }
        public int GetTimeIn()
        {
            return TimeIn;
        }
    }
}
