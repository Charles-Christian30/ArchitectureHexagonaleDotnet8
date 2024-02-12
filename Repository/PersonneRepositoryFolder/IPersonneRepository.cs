using Domaine.DataEntity.PersonneModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonneRepositoryFolder
{
    public interface IPersonneRepository
    {
        Personne CreatePersonne(Personne personne);
    }
}
