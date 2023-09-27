using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_app
{
    internal class Employee
    {
        public int Id { get; set; }
        public Attendance[] AttendanceArray { get; set; }

        public Employee(int id, AttendanceData attData)
        {
            Id = id;
            AttendanceArray = attData.AttendanceArray;
        }
    }
}
    

