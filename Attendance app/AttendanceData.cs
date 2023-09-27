using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_app
{
    internal class AttendanceData
    {
        public Attendance[] AttendanceArray { get; set; }

        public AttendanceData(Attendance[] attendanceArray)
        {
            AttendanceArray = attendanceArray;
        }
    }
}
