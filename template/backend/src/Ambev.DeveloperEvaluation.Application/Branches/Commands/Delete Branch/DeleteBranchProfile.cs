using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Commands.Delete_Branch
{
    public class DeleteBranchProfile : Profile
    {
        public DeleteBranchProfile()
        {
            CreateMap<Guid, DeleteBranchCommand>()
                .ConstructUsing(id => new DeleteBranchCommand(id));
        }
    }
}
