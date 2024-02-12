using Domaine.Context;
using Domaine.DataEntity.PersonneModel;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonneRepositoryFolder
{
    public class PersonneRepository : IPersonneRepository
    {
        private readonly leSiteDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public PersonneRepository(leSiteDbContext context, IUnitOfWork unitOfWork)
        {
            this._context = context;
            this._unitOfWork = unitOfWork;
        }
        public Personne CreatePersonne(Personne personne)
        {
            var result = this._context.personnes.Add(personne).Entity;
            this._unitOfWork.CompleteAsync();
            return result;
        }
    }
}
