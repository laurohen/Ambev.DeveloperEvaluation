using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Enums;
using Ambev.DeveloperEvaluation.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Specifications
{
    public class ActiveUserSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User user)
        {
            return user.Status == UserStatus.Active;
        }
    }
}
