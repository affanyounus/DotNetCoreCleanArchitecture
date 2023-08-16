using HRIS.Application.DTOs.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeRequest: IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
