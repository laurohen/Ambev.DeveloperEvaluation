using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums
{
    public enum UserStatus
    {
        Unknown = 0,
        Active,
        Inactive,
        Suspended
    }
}
