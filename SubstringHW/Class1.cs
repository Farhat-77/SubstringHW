using System;
using System.Collections.Generic;
using System.Text;

namespace SubstringHW
{
    public class AttendanceReport : BaseBean
    {
        public int Id { get; set; }
        public int serialNo { get; set; }
        public string aadharCard { get; set; }
        public string employeeName { get; set; }
    }

    public class BaseBean
    {
    }
}
