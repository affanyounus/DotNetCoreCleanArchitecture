﻿using HRIS.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.DTOs.LeaveRequest
{
    internal class LeaveRequestListDto: BaseDto
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
        
    }
}
