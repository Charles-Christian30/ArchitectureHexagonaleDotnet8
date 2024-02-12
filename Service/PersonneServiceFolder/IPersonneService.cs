using Domaine.DataEntity.PersonneModel;
using Domaine.Dto.PersonneDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PersonneServiceFolder
{
    public interface IPersonneService
    {
        Task<Personne> CreatePersonne(PersonneRequest personne);
    }
}
