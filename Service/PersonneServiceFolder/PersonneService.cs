using AutoMapper;
using Domaine.DataEntity.PersonneModel;
using Domaine.Dto.PersonneDto;
using Mediateur.Commandes;
using MediatR;
using Service.MappingHelpers.PersonneMappingHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PersonneServiceFolder
{
    public class PersonneService : IPersonneService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public PersonneService(IMediator mediator, IMapper mapper)
        {
            this._mediator = mediator;
            this._mapper = mapper;
        }
        public async Task<Personne> CreatePersonne(PersonneRequest personne)
        {
            var personneResult = await this._mediator.Send(new CreatePersonneCommand() {item = personne } );
            var response = this._mapper.Map<Personne>(personneResult);
            return response;
        }
    }
}
