using Domaine.DataEntity.PersonneModel;
using Domaine.Dto.PersonneDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateur.Commandes
{
    public class CreatePersonneCommand:IRequest<PersonneRequest>
    {
        public PersonneRequest item { get; set; }
    }
}
