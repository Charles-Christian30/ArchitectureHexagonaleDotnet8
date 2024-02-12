using AutoMapper;
using Domaine.DataEntity.PersonneModel;
using Domaine.Dto.PersonneDto;
using MediatR;
using Repository.PersonneRepositoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateur.Commandes
{
    public class CreatePersonneHandler : IRequestHandler<CreatePersonneCommand, PersonneRequest>
    {
        private readonly IPersonneRepository _repository;
        private readonly IMapper _mapper;

        public CreatePersonneHandler(IPersonneRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public Task<PersonneRequest> Handle(CreatePersonneCommand request, CancellationToken cancellationToken)
        {
            var personneMapping = _mapper.Map<Personne>(request.item);
            var insertPersonne = this._repository.CreatePersonne(personneMapping);
            var result  = this._mapper.Map<PersonneRequest>(insertPersonne);
             return Task.FromResult(result);
        }
    }
}
