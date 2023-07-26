using HRIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.Persistance.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
    {
    }
}
