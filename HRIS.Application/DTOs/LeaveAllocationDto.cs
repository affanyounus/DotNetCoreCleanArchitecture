using HRIS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.DTOs.Common
{
    public class LeaveAllocationDto: BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveTypeDto { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
