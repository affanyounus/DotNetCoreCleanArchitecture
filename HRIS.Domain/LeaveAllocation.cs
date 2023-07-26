using HRIS.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS.Domain
{
    public class LeaveAllocation: BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
       
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }


    }
}