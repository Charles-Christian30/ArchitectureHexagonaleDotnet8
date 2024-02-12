using Domaine.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWorkImplementation : IUnitOfWork
    {
        private readonly leSiteDbContext _context;
        public UnitOfWorkImplementation(leSiteDbContext context)
        {
            this._context = context;
        }

        public async Task CompleteAsync()
        {
            await this._context.SaveChangesAsync();
        }
    }
}
